
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.Data;
using QuanAnGiaDinh.DTOs;
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TaiKhoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{

		private readonly QuanAnGiaDinhDbContext db;
		public UserController(QuanAnGiaDinhDbContext _db)
		{
			this.db = _db;
		}
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignUp(AddUserVM addUserVM)
		{
			TaiKhoan user = new TaiKhoan();
			if(ModelState.IsValid)
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
					user.IsAdmin = addUserVM.Isadmin;
					user.IdRole = addUserVM.RoleID;
					await db.taiKhoans.AddAsync(user);
					await db.SaveChangesAsync();
				}
				catch(Exception ex)
				{
					TempData["Eror"] = "Đã xảy ra lỗi";
				}
			}
			else
			{
				TempData["Eror"] = "Đã xảy ra lỗi trong quá trình đăng ký tài khoản";
			}
			return RedirectToAction(nameof(Login));
		}
		public IActionResult Login()
		{
			return View();
		}	
		[HttpPost]
		public async Task<IActionResult> Login(LoginVM model)
		{
			model.UserName = model.UserName.Replace(" ", "").ToLower();
			var user = db.taiKhoans.AsNoTracking()
				.SingleOrDefault(u => u.User == model.UserName);
			if(user!=null)
			{
				HMACSHA512 hmac = new HMACSHA512();
				hmac.Key = user.PasswordSalt;
				var pwByte = Encoding.UTF8.GetBytes(model.Password);
				var pwHash = hmac.ComputeHash(pwByte);
				if (pwHash.SequenceEqual(user.PasswordHash))
				{
					var claims = new List<Claim>()
					{
						new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
						new Claim(ClaimTypes.Name,user.User),
						new Claim(ClaimTypes.GivenName,user.FullName),
						new Claim(ClaimTypes.Role,user.IsAdmin? "Admin" : "Member" )
					};
					var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
					var principal = new ClaimsPrincipal(claimsIdentity);
					var authProperty = new AuthenticationProperties
					{
						ExpiresUtc = DateTime.UtcNow.AddHours(6),
						IsPersistent = model.Check
					};
					await HttpContext.SignInAsync("Cookies", principal, authProperty); // startup đăng kí chữ j thì bên đăy đăng nhập chữ đó
					if (user.IsAdmin)
					{
						return RedirectToAction("Index", "Home");
					}
					else
					{
						return RedirectToAction("Index", "Home", new { area = "" });
					}
				}
                else
                {
					return RedirectToAction(nameof(Login));
				}
			}
			else
			{
				return RedirectToAction(nameof(Login));
			}
		}
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync("Cookies");
			return RedirectToAction("Index", "Home",new {area="" }) ;
		}
	}
}
