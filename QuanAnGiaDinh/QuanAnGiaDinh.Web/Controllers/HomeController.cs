using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.Controllers;
using QuanAnGiaDinh.Web.Models;
using QuanAnGiaDinh.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Controllers
{
	public class HomeController : QuanAnGiaDinhController
	{
		public HomeController(IWebHostEnvironment _host) : base(_host)
		{

		}	

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Menu()
		{
			return View();
		}
		public IActionResult MenuFastfood()
		{
			return View();
		}
		public IActionResult MenuDrink()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(DatBanVM datBanVM)
		{
			return Ok(await dbService.AddAsync<DatBan, DatBanVM>(datBanVM));
		}
		public  IActionResult _AddDatHang()
		{
			return PartialView("_AddDatHang");
		}
		[HttpPost]
		public async Task<IActionResult>_AddDatHang(BanHangVM banHangVM)
		{
			banHangVM.ThoiGianDatHang = DateTime.Now;
			return Ok(await dbService.AddAsync<DatHang, BanHangVM>(banHangVM));
		}
	}
}
