using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.Data.Services;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Shared;
using QuanAnGiaDinh.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace QuanAnGiaDinh.Web.Controllers
{
    public class UserClientController:QuanAnGiaDinhController
    {
		public int IdDonhang;
        public UserClientController(IWebHostEnvironment _host,QuanAnGiaDinhDbContext _db) : base(_host,_db)
        {
            dbService = new ServiceBase();
            db = _db;
        }
        public IActionResult _SignUp()
        {
            return PartialView();
        }
		[HttpPost]
		public async Task<IActionResult> _SignUp(AddUserClientVM addUserVM)
		{
			TaiKhoan user = new TaiKhoan();
			if (ModelState.IsValid)
			{
				try
				{
					HMACSHA512 hmac = new HMACSHA512();
					var pwByte = Encoding.UTF8.GetBytes(addUserVM.Password);
					user.PasswordHash = hmac.ComputeHash(pwByte);
					user.PasswordSalt = hmac.Key;
					user.User = addUserVM.UserName.Replace(" ", "").ToLower();
					user.FullName = addUserVM.FullName;
					user.CreateDate = DateTime.Now;
					user.IsAdmin = false;

					await db.taiKhoans.AddAsync(user);
					await db.SaveChangesAsync();
				}
				catch
				{
					
				}
				return Ok(true);
			}
			else
			{
				return Ok(false);
			}
			
		}
		public IActionResult ListCartofUser(int page=1)
        {
			var idUser = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
			var data = db.datHangs
			   .Where(x => x.IdTaiKhoan == idUser)
			   .Include(x=>x.chiTietDonDatHangs)
			   .OrderByDescending(u => u.Id)
			   .ToPagedList(page, 3);
			foreach(var item in data)
            {
				foreach(var itemps in item.chiTietDonDatHangs)
                {
					var monan = db.Menu.Find(itemps.IdMenu);
					itemps.menu = monan;
                }					
            }
			return View(data);
		}
	}
}
