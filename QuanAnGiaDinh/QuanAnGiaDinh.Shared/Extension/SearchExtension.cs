using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QuanAnGiaDinh.Shared.Extension
{
	public static class SearchExtension
	{
		/// <summary>
		/// https://stackoverflow.com/questions/58320767/linq-where-ef-functions-like-why-direct-properties-work-and-reflection-does-no
		/// </summary>
		public static IQueryable<T> Search<T>(this IQueryable<T> source, string propertyName, string keyword)
		{
			// Check property name
			if (string.IsNullOrEmpty(propertyName))
			{
				throw new ArgumentNullException(nameof(propertyName));
			}

			// Check the search term
			if (string.IsNullOrEmpty(keyword))
			{
				throw new ArgumentNullException(nameof(keyword));
			}

			// Check the property exists
			var property = typeof(T).GetProperty(propertyName);
			if (property == null)
			{
				throw new ArgumentException($"The property {typeof(T)}.{propertyName} was not found.", nameof(propertyName));
			}

			// Check the property type
			if (property.PropertyType != typeof(string))
			{
				throw new ArgumentException($"The specified property must be of type {typeof(string)}.", nameof(propertyName));
			}

			// Get expression constants
			var searchPattern = "%" + keyword.Replace(" ", "%") + "%";
			var itemParameter = Expression.Parameter(typeof(T), "item");
			var functions = Expression.Property(null, typeof(EF).GetProperty(nameof(EF.Functions)));
			var likeFunction = typeof(DbFunctionsExtensions).GetMethod(nameof(DbFunctionsExtensions.Like), new Type[] { functions.Type, typeof(string), typeof(string) });

			// Build the property expression and return it
			Expression selectorExpression = Expression.Property(itemParameter, property.Name);
			selectorExpression = Expression.Call(null, likeFunction, functions, selectorExpression, Expression.Constant(searchPattern));
			return source.Where(Expression.Lambda<Func<T, bool>>(selectorExpression, itemParameter));
		}
	}
}
