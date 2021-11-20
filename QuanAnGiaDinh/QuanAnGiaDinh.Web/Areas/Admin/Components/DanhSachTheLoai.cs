using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Component
{
	public class DanhSachTheLoai : ViewComponent
	{
		private readonly QuanAnGiaDinhDbContext db = new QuanAnGiaDinhDbContext();
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var danhsach = await db.TheLoaiMenu.ToListAsync();
			return View(danhsach);

		}
	}
}
