﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.ViewModels
{
	public class BanHangVM
	{
		public int Id { get; set; }
		public string TenKH { get; set; }
		public string DiaChi { get; set; }
		public string SDT { get; set; }
		public DateTime ThoiGianDatHang { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
