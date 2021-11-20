using QuanAnGiaDinh.Shared.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Shared.Attributes
{
	public class NotCloneAttribute : Attribute
	{
		public override string ToString()
		{
			return AdminConst.NOT_CLONE;
		}
	}
}
