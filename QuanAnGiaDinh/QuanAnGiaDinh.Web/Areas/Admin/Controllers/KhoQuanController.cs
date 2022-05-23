using QuanAnGiaDinh.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.KhoQuan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.MaHang;
using QuanAnGiaDinh.Data;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class KhoQuanController : QuanAnGiaDinhAdminController
	{
		public KhoQuanController(IWebHostEnvironment _host): base(_host)
		{
			dbService = new KhoQuanService();
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(DatatableParams input)
		{
			PagedResult listdata = new PagedResult();
			if(string.IsNullOrWhiteSpace(input.searchValue))
			{
				listdata = dbService.GetPagedList<KhoQuan, KhoQuanVM>
					(input.page, input.length);
			}
			else
			{
				listdata = dbService.GetPagedList<KhoQuan, KhoQuanVM>
					(input.page, input.length, x => x.Thucpham, input.searchValue);
			}
			return ForDatatable(input.draw, listdata);
		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<KhoQuan, KhoQuanVM>(id));
		}
		[HttpPost]
		public async Task<IActionResult> AddorUpdate(KhoQuanVM khoQuanVM)
		{
            try
            {
			if(khoQuanVM.Id==0)
			{
				QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
                    var data = db.MaHang.Find(khoQuanVM.MahangId);
					data.TongSoLuong = data.TongSoLuong + khoQuanVM.Soluong;
					db.Update(data);
					db.SaveChanges();
                    khoQuanVM.ngaynhap = DateTime.Now;
				return Ok(await dbService.AddAsync<KhoQuan, KhoQuanVM>(khoQuanVM));
			}
			return Ok(await dbService.UpdateAsync<KhoQuan, KhoQuanVM>(khoQuanVM));
            }
            catch (Exception ex) {
				return Ok(false);
			}
		} // éo hiểu hỏi anh tín nó xàm lol đó mấy này khó sài lắm haha
		[HttpDelete]
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<KhoQuan>(id));
		}
	}
}
