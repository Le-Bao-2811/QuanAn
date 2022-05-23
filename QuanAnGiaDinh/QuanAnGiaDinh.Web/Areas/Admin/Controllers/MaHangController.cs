using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using QuanAnGiaDinh.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.MaHang;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MaHangController : QuanAnGiaDinhAdminController
	{
		public MaHangController(IWebHostEnvironment _host) : base(_host)
		{
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult listdata=new PagedResult();
			if(string.IsNullOrWhiteSpace(input.searchValue))
			{
				listdata = dbService.GetPagedList<MaHang, MaHangVM>
					(input.page, input.length);
			}
			else
			{
				listdata = dbService.GetPagedList<MaHang, MaHangVM>
					(input.page, input.length, x => x.LoaiHang, input.searchValue);
			}
			return ForDatatable(input.draw, listdata);
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<MaHang, MaHangVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult> _AddorUpdate(MaHangVM maHangVM)
		{
			if(maHangVM.Id==0)
			{
				maHangVM.TongSoLuong = 0;
				return Ok(await dbService.AddAsync<MaHang, MaHangVM>(maHangVM));
			}	
			return Ok( await dbService.UpdateAsync<MaHang, MaHangVM>(maHangVM));
		}
		[HttpDelete]
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<MaHang>(id));
		}
	}
}
