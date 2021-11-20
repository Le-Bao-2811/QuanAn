using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.Shared;
using System.Linq.Dynamic.Core;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.ChucVu;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.MaHang;
using Microsoft.AspNetCore.Authorization;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ChucVuController : QuanAnGiaDinhAdminController
	{	
		public ChucVuController(IWebHostEnvironment _host): base(_host)
		{
			dbService = new ChucVuService();
		}

		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult listdata = new PagedResult();
			if (string.IsNullOrWhiteSpace(input.searchValue))
			{
				listdata = dbService.GetPagedList<ChucVu, ChucVuVM>
					(input.page, input.length);
			}
			else
			{
				listdata = dbService.GetPagedList<ChucVu, ChucVuVM>
					(input.page, input.length, x => x.ChucVuNV, input.searchValue);
			}
			return ForDatatable(input.draw, listdata);
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<ChucVu, ChucVuVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult> _AddorUpdate(ChucVuVM chucVuVM)
		{
			if (chucVuVM.Id==0)
			{
				return Ok(await dbService.AddAsync<ChucVu, ChucVuVM>(chucVuVM));
			}
			return Ok(await dbService.UpdateAsync<ChucVu, ChucVuVM>(chucVuVM));
		}
		[HttpDelete]
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<ChucVu>(id));
		}

	}
}
