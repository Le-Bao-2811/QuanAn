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
    public class HomeController : Controller
    {
        QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
        public IActionResult Index()
        {
            List<IGrouping<string,DatHang>> listdata = db.datHangs
                .AsEnumerable()
                .GroupBy(x => x.ThoiGianDatHang.ToString("dd//MM/yyyy")).ToList();
            List<ThongKeVM> data = new List<ThongKeVM>();
            
            foreach(var item in listdata)
            {
                ThongKeVM itemp = new ThongKeVM();
                itemp.date = item.Key;
                foreach(var gia in item)
                {
                    itemp.value += gia.Sotien;
                }
                data.Add(itemp);
            }
            Console.WriteLine(data);
            return View();
        }
    }
}
