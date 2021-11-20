using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.KVLamViec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class KVLamViecController : QuanAnGiaDinhAdminController
	{
		public KVLamViecController(IWebHostEnvironment _host):base(_host)
		{
			dbService = new KVLamViecService();
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
				lisdata = dbService.GetPagedList<KVLamViec,KVucLamViecVM>
					(input.page,input.length);
			}	
			else
			{
				lisdata = dbService.GetPagedList<KVLamViec, KVucLamViecVM>
					(input.page, input.length, x => x.KVucLamViec, input.searchValue);
			}
			return ForDatatable(input.draw, lisdata);
			
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<KVLamViec, KVucLamViecVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult> _AddorUpdate(KVucLamViecVM data)
		{	
			if(data.Id==0)
			{
				return Ok(await dbService.AddAsync<KVLamViec, KVucLamViecVM>(data));
			}
			return Ok(await dbService.UpdateAsync<KVLamViec, KVucLamViecVM>(data));
		}
	
		[HttpDelete]
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<KVLamViec>(id));
		}
		
	}
}
