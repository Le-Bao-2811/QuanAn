using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Controllers
{
	public class TabController : Controller
	{
		readonly QuanAnGiaDinhDbContext db;
		public TabController(QuanAnGiaDinhDbContext _db)
		{
			db = _db;
		}
		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> MenuClient()
		{
			var listdata = await db.Menu
				.Where(x => x.IdTheLoai == 2 && x.ThucDon != null)
				.ToListAsync();
			return Json(listdata);
		}
		public async Task<IActionResult> Menufastfood()
		{
			var listdata = await db.Menu
				.Where(x => x.IdTheLoai == 1 && x.ThucDon != null)
				.ToListAsync();
			return Json(listdata);
		}
		public async Task<IActionResult> Menudrinks()
		{
			var listdata = await db.Menu
				.Where(x => x.IdTheLoai == 3 && x.ThucDon != null)
				.ToListAsync();
			return Json(listdata);
		}
		public async Task<IActionResult> Cart(List<int> idList)
		{
			if (idList.Count == 0)
			{
				return Ok();
			}
			else
			{
				List<Menu> response = new List<Menu>();
				foreach (var item in idList)
				{
					response.Add(await db.Menu.AsNoTracking().Where(x => x.Id == item).SingleOrDefaultAsync());
				}
				return Ok(response);
			}
		}
		
	}
	
}
