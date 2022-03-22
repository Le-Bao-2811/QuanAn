using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Shared.Const;
using QuanAnGiaDinh.Shared.Extension;

namespace QuanAnGiaDinh.Data.Services
{
	public class ServiceBase : IDisposable
	{
		protected string KEY = "Id";
		protected string ORDER_CONTDITION = "DisplayOrder.HasValue desc, DisplayOrder, Id desc";
		protected string NOT_DELETED_CONDITION = "LoaiHang != \"Không tồn tại\" ";
		protected string DELETE_STATEMENT = "LoaiHang = N'Không tồn tại'";

		protected string[] PREFIX_NAMESPACE = new[] { "QuanAn" };

		protected QuanAnGiaDinhDbContext db;
		private bool disposed = false;

		public ServiceBase()
		{
			db = new QuanAnGiaDinhDbContext();
		}
		public ServiceBase(QuanAnGiaDinhDbContext _db)
		{
			db = _db;
		}

		public QuanAnGiaDinhDbContext GetContext()
		{
			return db;
		}

		public bool Any<TTable>(Expression<Func<TTable, bool>> expression) where TTable : class
		{
			return db.Set<TTable>().Any(expression);
		}

		#region Get
		public TModel Get<TModel>(object id) where TModel : class
		{
			return db.Find<TModel>(id);
		}
		public TModel Get<TTable, TModel>(int id)
			where TModel : class where TTable : class
		{
			var data = db.Set<TTable>()
					.AsNoTracking()
					.Where(KEY + " == " + id + " && " + NOT_DELETED_CONDITION)
					.Select(this.GetSelectedFields<TModel>())
					.SingleOrDefault();
			return CastTo<TModel>(data);
		}

		public PagedResult GetPagedList<TModel>(int page, int size) where TModel : class
		{
			var query = db.Set<TModel>()
				.AsNoTracking()
				.Where(NOT_DELETED_CONDITION)
				.OrderBy(ORDER_CONTDITION);
			IQueryable data = query.Page(page, size);
			var totalRow = query.Count();
			return new PagedResult
			{
				CurrentPage = page,
				PageSize = size,
				Queryable = data,
				RowCount = totalRow
			};
		}

		public PagedResult GetPagedList<TTable, TModel>(int page, int size) where TModel : class where TTable : class
		{
			 var query = db.Set<TTable>()
						.AsNoTracking()
						.Where(NOT_DELETED_CONDITION)
						.Select(this.GetSelectedFields<TModel>())
						.OrderBy(ORDER_CONTDITION);

			Console.WriteLine(query.ToQueryString()); // => Xem query
			var result = query.PageResult(page, size);
			result.Queryable = this.CastToList<TModel>(result);
			return result;
		}

		public PagedResult GetPagedList<TTable, TModel>(int page, int size, Expression<Func<TModel, object>> expr, string keyword) where TModel : class where TTable : class
		{
			string columnName = GetPropertyName(expr);
			var query = db.Set<TTable>()
						.Where(NOT_DELETED_CONDITION)
						.Search(columnName, keyword)
						.AsNoTracking()
						.Select(this.GetSelectedFields<TModel>())
						.OrderBy(ORDER_CONTDITION);

			// Console.WriteLine(query.ToQueryString()); => Xem query
			var result = query.PageResult(page, size);
			result.Queryable = this.CastToList<TModel>(result);
			return result;
		}

		#endregion

		#region Add
		public async Task<bool> AddAsync<TModel>(TModel entity) where TModel : class
		{
			try
			{
				await db.AddAsync(entity);
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		public async Task<bool> AddAsync<TTable, TModel>(TModel entity) where TModel : class where TTable : class
		{
			try
			{
				TTable model = this.CastTo<TTable>(entity);
				await db.AddAsync(model);
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		#endregion
		public async Task<bool> UpdateAsync<TTable, TModel>(TModel entity)
			where TTable : class where TModel : class
		{
			var keyVal = entity.GetType().GetProperty(KEY)?.GetValue(entity).ToString();
			if (!string.IsNullOrEmpty(keyVal))
			{
				try
				{
					var query = "UPDATE " + typeof(TTable).Name
								+ " SET " + GetUpdateFields<TModel>()
								+ " WHERE " + KEY + "=" + keyVal;

					List<SqlParameter> GetSqlParams()
					{
						var listParams = this.GetFieldsAsList<TModel>();
						var sqlParams = new List<SqlParameter>();
						foreach (var item in listParams)
						{
							var param = new SqlParameter();
							var paramValue = entity.GetType().GetProperty(item)?.GetValue(entity);
							param.ParameterName = item;
							param.Value = paramValue ?? DBNull.Value;
							sqlParams.Add(param);
						}
						return sqlParams;
					}
					var z = GetSqlParams();
					await db.Database.ExecuteSqlRawAsync(query, GetSqlParams());
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
			else
			{
				Console.WriteLine("Đối tượng không có thuộc tính Id, không thể update");
				return false;
			}
		}

		#region Delete
		public async Task<bool> DeleteAsync<TTable>(int id) where TTable : class
		{
			try
			{
				var query = "UPDATE " + typeof(TTable).Name
							+ " SET " + DELETE_STATEMENT
							+ " WHERE " + KEY + "=" + id;

				await db.Database.ExecuteSqlRawAsync(query);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public async Task<bool> HardDeleteAsync<TTable>(int id) where TTable : class
		{
			try
			{
				var query = "DELETE " + typeof(TTable).Name
							+ " WHERE " + KEY + "=" + id;
				await db.Database.ExecuteSqlRawAsync(query);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		#endregion
		public async Task SaveAsync()
		{
			await db.SaveChangesAsync();
		}

		#region Helper
		protected string GetPropertyName<TModel>(Expression<Func<TModel, object>> expr) where TModel : class
		{
			return ((MemberExpression)expr.Body).Member.Name;
		}
		protected string GetValueOfProp(object obj, string columnName)
		{
			return obj.GetType().GetProperty(columnName).GetValue(obj, null).ToString();
		}
		public string GetSelectedFields<TObject>(string prefix = "")
		{
			string query = "";
			if (prefix.IsNullOrEmpty())
			{
				query = "new {";
			}
			var type = typeof(TObject);

			bool isNotUpdate = false;
			foreach (var item in type.GetProperties())
			{
				var attrs = item.GetCustomAttributes(true);
				foreach (var at in attrs)
				{
					if (at.ToString() == AdminConst.NOT_CLONE) isNotUpdate = true;
				}
				if (isNotUpdate)
				{
					isNotUpdate = !isNotUpdate;
					continue;
				}

				if (item.PropertyType.IsGenericType)
				{
					// Trường hợp property là ICollection
					var _type = item.PropertyType.GetGenericTypeDefinition();
					if (_type == typeof(IEnumerable<>) || _type == typeof(ICollection<>))
					{
						//var dPropType = type.GetProperty(item.Name).PropertyType.GetGenericArguments().Single();
						//MethodInfo method = typeof(ServiceBase).GetMethod("GetSelectedFields");
						//MethodInfo generic = method.MakeGenericMethod(dPropType);
						//// Đệ f*uking quy
						//query += $"{item.Name}.Select({generic.Invoke(this, new object[] { "" })}) as {item.Name},";
						//continue;
					}
				}

				// Trường hợp property là 1 object thuộc project
				if (PREFIX_NAMESPACE.Any(x => item.PropertyType.FullName.IndexOf(x) == 0))
				{
					var dPropType = type.GetProperty(item.Name).PropertyType;
					// Đệ f*uking quy
					MethodInfo method = typeof(ServiceBase).GetMethod("GetSelectedFields");
					MethodInfo generic = method.MakeGenericMethod(dPropType);
					query += generic.Invoke(this, new[] { $"{item.Name}" });
					continue;
				}
				var column = prefix.IsNullOrEmpty() ? item.Name : $"{prefix}.{item.Name} as _{prefix}_{item.Name}";
				query += column + ",";
			}

			if (prefix.IsNullOrEmpty() && query[^1] == ',')
			{
				query = query.Remove(query.Length - 1, 1);
				query += "}";
			}
			return query;
		}
		protected string GetUpdateFields<TObject>()
		{
			string query = "";
			var type = typeof(TObject);

			bool isNotUpdate = false;
			foreach (var item in type.GetProperties())
			{
				var attrs = item.GetCustomAttributes(true);
				if (item.Name == KEY) continue;
				foreach (var at in attrs)
				{
					if (at.ToString() == AdminConst.NOT_CLONE) isNotUpdate = true;
				}
				if (isNotUpdate)
				{
					isNotUpdate = !isNotUpdate;
					continue;
				}
				query += item.Name + "=@" + item.Name + ",";
			}
			return query.Remove(query.Length - 1, 1);
		}

		protected List<string> GetFieldsAsList<TObject>()
		{
			List<string> properties = new List<string>();
			var type = typeof(TObject);

			bool isNotUpdate = false;
			foreach (var item in type.GetProperties())
			{
				var attrs = item.GetCustomAttributes(true);
				foreach (var at in attrs)
				{
					if (at.ToString() == AdminConst.NOT_CLONE) isNotUpdate = true;
				}
				if (isNotUpdate)
				{
					isNotUpdate = !isNotUpdate;
					continue;
				}
				properties.Add(item.Name);
			}
			return properties;
		}

		public IQueryable CastToList<TModel>(PagedResult list) where TModel : class
		{
			var pageResult = new List<TModel>();
			foreach (var item in list.Queryable)
			{
				pageResult.Add(CastTo<TModel>(item));
			}
			return pageResult.AsQueryable();
		}

		public IEnumerable CastToList2<TModel>(IEnumerable list) where TModel : class
		{
			var result = new List<TModel>();
			foreach (var item in list)
			{
				result.Add(CastTo<TModel>(item));
			}
			return result;
		}

		public TModel CastTo<TModel>(object data, bool replaceWithNull = true) where TModel : class
		{
			try
			{
				if (data == null) return null;
				var sType = data.GetType();
				var dType = typeof(TModel);

				var dObject = Activator.CreateInstance<TModel>();


				bool isNotUpdate = false;
				foreach (var item in sType.GetProperties())
				{
					var attrs = item.GetCustomAttributes(true);

					// NotClone, null hoặc bị lỗi thì kemeno, vẫn tiếp tục
					foreach (var at in attrs)
					{
						if (at.ToString() == AdminConst.NOT_CLONE) isNotUpdate = true;
					}
					if (isNotUpdate)
					{
						isNotUpdate = !isNotUpdate;
						continue;
					}
					object value = null;
					try
					{
						value = item.GetValue(data, null);
					}
					catch
					{
						continue;
					}
					if (value == null && !replaceWithNull)
					{
						continue;
					}

					if (item.PropertyType.IsGenericType)
					{
						// Trường hợp property là ICollection
						var type = item.PropertyType.GetGenericTypeDefinition();
						if (type == typeof(ICollection<>) || type == typeof(IEnumerable<>))
						{
							if ((int)value.GetType().GetProperty("Count").GetValue(value) > 0)
							{
								var dPropType = dType.GetProperty(item.Name).PropertyType.GetGenericArguments().Single();
								// Đệ f*uking quy
								MethodInfo method = typeof(ServiceBase).GetMethod("CastToList2");
								MethodInfo generic = method.MakeGenericMethod(dPropType);
								dType.GetProperty(item.Name)?.SetValue(dObject, generic.Invoke(this, new[] { value }));
							}
							continue;
						}
					}

					dType.GetProperty(item.Name)?.SetValue(dObject, value);
				}

				var joinedColumn = sType.GetProperties().Where(x => x.Name.StartsWith("_")).GroupBy(y => y.Name.Split('_')[1]);
				foreach (var list in joinedColumn)
				{
					object prop = null;
					foreach (var item in list)
					{
						var propertyNames = item.Name.Remove(0, 1).Split('_');
						//var dPropValue = dType.GetProperty(propertyNames[0]).GetValue(dObject);
						if (prop == null) prop = Activator.CreateInstance(dType.GetProperty(propertyNames[0]).PropertyType);
						prop.GetType().GetProperty(propertyNames[1]).SetValue(prop, sType.GetProperty(item.Name).GetValue(data));
					}
					dType.GetProperty(list.Key)?.SetValue(dObject, prop);
				}
				return dObject;
			}
			catch(Exception ex)
			{
				return null;
				Console.Write(ex.Message);
			}
		}
		#endregion

		#region Dispose
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					db.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
