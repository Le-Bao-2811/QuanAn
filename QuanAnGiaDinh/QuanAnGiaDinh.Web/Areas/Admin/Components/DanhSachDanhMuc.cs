using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Components
{
	public class DanhSachDanhMuc :ViewComponent
	{
		QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var danhsach = await db.DanhMucMenu.ToListAsync();
			return View(danhsach);
		}
	}
}
