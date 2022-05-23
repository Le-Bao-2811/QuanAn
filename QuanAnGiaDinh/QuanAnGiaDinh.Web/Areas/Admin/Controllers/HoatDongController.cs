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
    [Area("Admin")]
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
        public IActionResult Duyet(int id)
        {
            var data = db.datHangs.Find(id);
            data.Duyet = true;
            db.datHangs.Update(data);
            db.SaveChanges();
            return RedirectToAction("ListCart","HoatDong");
        }
        public IActionResult XemDatHang(int id)
        {
            var data = db.datHangs.Find(id);
            data.chiTietDonDatHangs = db.chiTietDonDatHangs.Where(x => x.IdDatHang == id).ToList();
            
                foreach (var itemps in data.chiTietDonDatHangs)
                {
                    var monan = db.Menu.Find(itemps.IdMenu);
                    itemps.menu = monan;
                }
            return PartialView(data);

        }
        public IActionResult ListDatBan(int page = 1)
        {
            var data = db.datBans
             .OrderByDescending(u => u.Id)
             .ToPagedList(page, 8);
            return View(data);
        }
        public IActionResult DuyetDB(int id)
        {
            var data = db.datBans.Find(id);
            data.Duyet = true;
            db.datBans.Update(data);
            db.SaveChanges();
            return RedirectToAction("ListDatBan", "HoatDong");
        }
    }
}
