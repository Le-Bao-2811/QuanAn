using QuanAnGiaDinh.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("AdminConst.AREA_NAME")]
	[Authorize]
	public class QuanAnGiaDinhAdminController : Controller
	{
		//Tạo thuộc tính cho môi trường lưu trữ
		//Thêm Microsoft.AspNetCore.Hosting vào bộ điều khiển của bạn
		protected readonly IWebHostEnvironment Host;
		//Đăng ký dịch vụ trong phương thức khởi tạo
		protected ServiceBase dbService;
		public QuanAnGiaDinhAdminController(IWebHostEnvironment _host)
		{
			Host = _host;
			dbService = new ServiceBase();
		}

		protected IActionResult ForDatatable(int inDraw, PagedResult data)
		{
			dynamic _dataTable = new
			{
				draw = inDraw,
				recordsTotal = data.RowCount,
				recordsFiltered = data.RowCount,
				data = data.Queryable
			};
			return Ok(_dataTable);
		}

		protected override void Dispose(bool disposing)
		{
			dbService.Dispose();
			base.Dispose(disposing);
		}
	}
}

