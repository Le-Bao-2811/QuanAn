using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Components
{
    public class DanhSachKVLV:ViewComponent
    {
        readonly QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.KVLamViec.ToListAsync();
            return View(data);
        }
    }
}
