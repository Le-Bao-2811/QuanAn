using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Data.Services.Admin;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MenuController : QuanAnGiaDinhAdminController
	{
		public MenuController(IWebHostEnvironment _host):base(_host)
		{
			dbService = new MenuService();
		}

		string UploadImgAndReturnPath(IFormFile file, string childFolder = "/img/", bool saveInWwwRoot = true)
		{
			var y = Host.WebRootPath;
			var root = saveInWwwRoot ? Host.WebRootPath : Host.ContentRootPath;
			var filename = Path.GetFileNameWithoutExtension(file.FileName)
							+ DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-fff")
							+ Path.GetExtension(file.FileName);
			if (!Directory.Exists(root + childFolder))
			{
				Directory.CreateDirectory(root + childFolder);
			}
			var relativePath = childFolder + filename;
			var path = root + relativePath;
			var x = new FileStream(path, FileMode.Create);
			file.CopyTo(x);
			x.Dispose();
			GC.Collect();
			return relativePath;
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
				lisdata = dbService.GetPagedList<Menu,MenuVM>
					(input.page, input.length);
			}
			else
			{
				lisdata=dbService.GetPagedList<Menu, MenuVM>
					(input.page, input.length,x=>x.ThucDon,input.searchValue);
			}
			return ForDatatable(input.draw, lisdata);

		}
		public IActionResult Get(int id)
		{
			return Ok(dbService.Get<Menu, MenuVM>(id));
		}
		public PartialViewResult _AddorUpdate()
		{
			QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
			var danhsach=db.TheLoaiMenu.ToList();
			ViewBag.Theloai = new SelectList(danhsach, "Id", "TheLoai");
			return PartialView("_AddorUpdate"); 
		}
		[HttpPost]
		public async Task<IActionResult>_AddorUpdate(MenuVM menuVM)
		{
			
			if(menuVM.Id==0)
			{
				if (menuVM.Hinh != null)
				{
					string image = UploadImgAndReturnPath(menuVM.Hinh, "/img/menu/");
					image = image.Split('/').Last();
					menuVM.duongdan = image;
				}
				return Ok(await dbService.AddAsync<Menu, MenuVM>(menuVM));
			}
			return Ok(await dbService.UpdateAsync<Menu, MenuVM>(menuVM));
		}
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<Menu>(id));
		}
	}
}
