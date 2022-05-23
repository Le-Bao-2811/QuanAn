using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Data.Services;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThongKe()
        {
            List<IGrouping<string, DatHang>> listdata = db.datHangs
                .AsEnumerable()
                .GroupBy(x => x.ThoiGianDatHang.ToString("dd//MM/yyyy")).ToList();
            List<ThongKeVM> data = new List<ThongKeVM>();

            foreach (var item in listdata)
            {
                ThongKeVM itemp = new ThongKeVM();
                
                foreach (var gia in item)
                {
                    itemp.date = gia.ThoiGianDatHang;
                    itemp.value += gia.Sotien;
                }
                data.Add(itemp);
            }            
            return new JsonResult(data);
        }
    }
}
