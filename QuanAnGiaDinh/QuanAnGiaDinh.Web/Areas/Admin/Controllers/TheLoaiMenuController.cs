using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TheLoai;
using QuanAnGiaDinh.Shared;
using System.Linq.Dynamic.Core;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TheLoaiMenuController : QuanAnGiaDinhAdminController
	{
		public TheLoaiMenuController(IWebHostEnvironment _host):base(_host)
		{
			dbService = new TheLoaiMenuService();
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<TheLoaiMenu, TheLoaiMenuVM>(id));
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult data = new PagedResult();
			if(string.IsNullOrWhiteSpace(input.searchValue))
			{
				data = dbService.GetPagedList<TheLoaiMenu, TheLoaiMenuVM>
					(input.page, input.length);
			}
			else
			{
				data = dbService.GetPagedList<TheLoaiMenu, TheLoaiMenuVM>
				(input.page, input.length,x=>x.TheLoai,input.searchValue);
			}
			return ForDatatable(input.draw, data);
		}	
		[HttpPost]
		public async Task<IActionResult>_AddorUpdate(TheLoaiMenuVM theLoaiMenuVM)
		{
			if(theLoaiMenuVM.Id==0)
			{
				return Ok(await dbService.AddAsync<TheLoaiMenu, TheLoaiMenuVM>(theLoaiMenuVM));
			}
			return Ok(await dbService.UpdateAsync<TheLoaiMenu, TheLoaiMenuVM>(theLoaiMenuVM));
		}	
		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<TheLoaiMenu>(id));
		}
	}
}
