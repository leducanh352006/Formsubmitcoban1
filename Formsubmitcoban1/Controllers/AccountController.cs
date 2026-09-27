using Microsoft.AspNetCore.Mvc;
using YourAppName.Models; // Khai báo namespace chứa LoginViewModel

namespace YourAppName.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        // Hiển thị form đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        // Xử lý dữ liệu khi form submit
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Kiểm tra điều kiện bài toán
            if (model.Username == "admin" && model.Password == "123")
            {
                ViewBag.Message = "Login success";
           
            }
            else
            {
                ViewBag.Message = "Login failed";
            
            }

            // Trả lại View kèm theo dữ liệu người dùng vừa nhập (để không bị mất chữ trên form)
            return View(model);
        }
    }
}