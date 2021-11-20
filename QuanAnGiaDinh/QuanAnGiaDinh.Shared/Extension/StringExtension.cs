using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Shared.Extension
{
	public static class StringExtension
	{
		public static bool IsNullOrEmpty(this string text)
		{
			return String.IsNullOrEmpty(text);
		}

		public static bool IsNullOrWhiteSpace(this string text)
		{
			return String.IsNullOrWhiteSpace(text);
		}
	}
}
