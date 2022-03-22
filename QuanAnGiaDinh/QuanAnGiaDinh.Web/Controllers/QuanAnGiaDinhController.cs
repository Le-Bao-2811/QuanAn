using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Controllers
{
	public class QuanAnGiaDinhController : Controller
	{
		//Thêm Microsoft.AspNetCore.Hosting vào bộ điều khiển của bạn
		protected readonly IWebHostEnvironment Host;
		//Đăng ký dịch vụ trong phương thức khởi tạo
		protected ServiceBase dbService;
		protected QuanAnGiaDinhDbContext db;
		public QuanAnGiaDinhController(IWebHostEnvironment _host,QuanAnGiaDinhDbContext _db)
		{
			Host = _host;
			dbService = new ServiceBase();
			db = _db;
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
