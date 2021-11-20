using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TrangThaiKho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using QuanAnGiaDinh.Data.Services.Admin;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TrangThaiKhoController : QuanAnGiaDinhAdminController
	{
		public TrangThaiKhoController(IWebHostEnvironment _host):base(_host)
		{
			dbService = new TinhTrangKhoService();
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult listdata = new PagedResult();
			if (string.IsNullOrWhiteSpace(input.searchValue))
			{
				listdata = dbService.GetPagedList<TrangThaiKho, TrangThaiKhoVM>
					(input.page, input.length);
			}
			else
			{
				listdata = dbService.GetPagedList<TrangThaiKho, TrangThaiKhoVM>
					(input.page, input.length, x => x.TrangThai, input.searchValue);
			}
			return ForDatatable(input.draw, listdata);
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<TrangThaiKho, TrangThaiKhoVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult>_AddorUpdate(TrangThaiKhoVM trangThaiKhoVM)
		{
			if(trangThaiKhoVM.Id==0)
			{
				return Ok(await dbService.AddAsync<TrangThaiKho, TrangThaiKhoVM>(trangThaiKhoVM));
			}
			return Ok(await dbService.UpdateAsync<TrangThaiKho, TrangThaiKhoVM>(trangThaiKhoVM));
		}

	}
}
