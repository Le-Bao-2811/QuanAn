using DiffMatchPatch;
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
			return PartialView("_AddorUpdate"); 
		}
		[HttpPost]
		public async Task<IActionResult>_AddorUpdate(MenuVM menuVM)
		{
            try
            {

			if (menuVM.Hinh != null)
			{
				string image = UploadImgAndReturnPath(menuVM.Hinh, "/img/menu/");
				image = image.Split('/').Last();
				menuVM.duongdan = image;
			}
			if (menuVM.Id==0)
			{				
				return Ok(await dbService.AddAsync<Menu, MenuVM>(menuVM));
			}
			return Ok(await dbService.UpdateAsync<Menu, MenuVM>(menuVM));
            }
			catch(Exception ex)
            {
				Console.Write(ex);
				return Ok(false);
            }
		}
		public async Task<IActionResult>Delete(int id)
		{
			return Ok(await dbService.DeleteAsync<Menu>(id));
		}
		public IActionResult CheckString(string monan)
        {
			QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
			var data = db.Menu.ToList();
			diff_match_patch dmp = new diff_match_patch();
			List<Diff> check=new List<Diff>();
			foreach (var item in data)
            {
				List<Diff> diff = dmp.diff_main(item.ThucDon,monan);
				dmp.diff_cleanupSemantic(diff);				
            }
			// Result: [(-1, "Hell"), (1, "G"), (0, "o"), (1, "odbye"), (0, " World.")]
			// Result: [(-1, "Hello"), (1, "Goodbye"), (0, " World.")]
			return new JsonResult(check);
		}
	}
}
