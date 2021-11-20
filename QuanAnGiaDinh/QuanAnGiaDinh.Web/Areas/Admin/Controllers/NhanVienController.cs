using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class NhanVienController : QuanAnGiaDinhAdminController
	{
		public NhanVienController(IWebHostEnvironment _host):base(_host)
		{
			dbService = new NhanVienService();
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult lisdata = new PagedResult();
			if(string.IsNullOrWhiteSpace(input.searchValue))
			{
				lisdata = dbService.GetPagedList<NhanVien, NhanVienVM>
					(input.page, input.length);
			}
			else
			{
				lisdata = dbService.GetPagedList<NhanVien, NhanVienVM>
					(input.page, input.length, x => x.HoTen, input.searchValue);
			}
			return ForDatatable(input.draw, lisdata);
		}
		[HttpPost]
		public async Task<IActionResult> _AddorUpdate(NhanVienVM nhanVienVM)
		{
			if(nhanVienVM.Id==0)
			{
				nhanVienVM.NgayVaoLam = DateTime.Now;
				return Ok(await dbService.AddAsync<NhanVien, NhanVienVM>(nhanVienVM));
			}
			return Ok(await dbService.UpdateAsync<NhanVien, NhanVienVM>(nhanVienVM));
		}

	}
}
