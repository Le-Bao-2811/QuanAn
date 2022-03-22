using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.DanhMucVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DanhMucMenuController : QuanAnGiaDinhAdminController
	{
		public DanhMucMenuController(IWebHostEnvironment _host) : base(_host)
		{
			dbService = new DanhMucMenuService();
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
				listdata = dbService.GetPagedList<DanhMucMenu, DannhMucMenuVM>
					(input.page, input.length);
			}
			else
			{
				listdata = dbService.GetPagedList<DanhMucMenu, DannhMucMenuVM>
					(input.page, input.length, x => x.DanhMuc, input.searchValue);
			}
			return ForDatatable(input.draw, listdata);
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<DanhMucMenu, DannhMucMenuVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult> _AddorUpdate(DannhMucMenuVM chucVuVM)
		{
			if (chucVuVM.Id == 0)
			{
				return Ok(await dbService.AddAsync<DanhMucMenu, DannhMucMenuVM>(chucVuVM));
			}
			return Ok(await dbService.UpdateAsync<DanhMucMenu, DannhMucMenuVM>(chucVuVM));
		}
		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<DanhMucMenu>(id));
		}

	}
}
