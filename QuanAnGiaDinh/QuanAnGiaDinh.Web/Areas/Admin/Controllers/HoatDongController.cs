using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
    public class HoatDongController : Controller
    {
        QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
        public IActionResult ListCart(int page=1)
        {
            var data = db.datHangs
               .Include(x => x.chiTietDonDatHangs)
               .OrderByDescending(u => u.Id)
               .ToPagedList(page, 8);
            foreach (var item in data)
            {
                foreach (var itemps in item.chiTietDonDatHangs)
                {
                    var monan = db.Menu.Find(itemps.IdMenu);
                    itemps.menu = monan;
                }
            }
            return View(data);
        }
        public IActionResult ListDatBan(int page = 1)
        {
            var data = db.datBans
             .OrderByDescending(u => u.Id)
             .ToPagedList(page, 8);
            return View(data);
        }
    }
}
