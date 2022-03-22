using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Data.Services.Client;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.Areas.Admin.Controllers;
using QuanAnGiaDinh.Web.Models;
using QuanAnGiaDinh.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace QuanAnGiaDinh.Web.Controllers
{
	public class HomeController : QuanAnGiaDinhController
	{
		public HomeController(IWebHostEnvironment _host,QuanAnGiaDinhDbContext _db) : base(_host,_db)
		{
            dbService = new MenuClientService();
            db = _db;
		}	
		public IActionResult Index()
		{
            return View();
		}
		public IActionResult Menu(int page=1)
		{
            var data = db.Menu
                 .Where(x=>x.ThucDon!=null&&x.IdTheLoai==2)
                 .OrderByDescending(u => u.Id)
                 .ToPagedList(page, 3);
            return View(data);
        }
		public IActionResult MenuFastfood(int page =1)
		{
            var data = db.Menu
                .Where(x => x.ThucDon != null && x.IdTheLoai == 1)
                .OrderByDescending(u => u.Id)
                .ToPagedList(page, 3);
            return View(data);
        }
		public IActionResult MenuDrink(int page =1)
		{
            var data = db.Menu
                .Where(x => x.ThucDon != null && x.IdTheLoai == 3)
                .OrderByDescending(u => u.Id)
                .ToPagedList(page, 3);
            return View(data);
        }

		[HttpPost]
		public async Task<IActionResult> Add(DatBanVM datBanVM)
		{
			return Ok(await dbService.AddAsync<DatBan, DatBanVM>(datBanVM));
		}
        [Authorize]
        public  IActionResult _AddDatHang()
		{
			return PartialView("_AddDatHang");
		}
        [Authorize]
		[HttpPost]
		public async Task<IActionResult>_AddDatHang(BanHangVM banHangVM)
		{
            try
            {
            DatHang donDatHang = new DatHang();
            donDatHang.TenKH = banHangVM.TenKH;
            donDatHang.SDT = banHangVM.SDT;
            donDatHang.DiaChi=banHangVM.DiaChi;
            donDatHang.ThoiGianDatHang = DateTime.Now;
            donDatHang.IdTaiKhoan = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
             var cookieList = Request.Cookies.Where(x => x.Key.Contains("products_"))
                .ToList();
            List<ChiTietDonDatHang> chiTietDonDatHangList = new List<ChiTietDonDatHang>();
            foreach (var item in cookieList)
            {
                try
                {
                    int currentID = Convert.ToInt32(item.Key.Replace("products_", ""));
                    Menu thisProduct = dbService.Get<Menu>(currentID);
                    ChiTietDonDatHang chiTietDonDatHang = new ChiTietDonDatHang()
                    {
                        IdMenu = currentID,
                        SoLuong = Convert.ToInt32(item.Value)
                    };
                    chiTietDonDatHang.ThanhTien = thisProduct.GiaTien * chiTietDonDatHang.SoLuong;
                    chiTietDonDatHangList.Add(chiTietDonDatHang);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    continue;
                }
            }
            donDatHang.chiTietDonDatHangs = chiTietDonDatHangList;
            double tamTinh = 0;
            foreach (var item in donDatHang.chiTietDonDatHangs)
            {
                tamTinh += item.ThanhTien;
            }
            donDatHang.Sotien = Convert.ToInt32(tamTinh);
            await dbService.AddAsync<DatHang>(donDatHang);
            return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }
	}
}
