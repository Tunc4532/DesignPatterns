using DessignPattern.ObServer.DAL;
using DessignPattern.ObServer.Models;
using DessignPattern.ObServer.ObServerPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DessignPattern.ObServer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObServerObject _obServerObject;

        public RegisterController(UserManager<AppUser> userManager, ObServerObject obServerObject)
        {
            _userManager = userManager;
            _obServerObject = obServerObject;
        }
        //user kayıt olma işlemi kod bloğu
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewmodel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                Email = model.Email,
                UserName = model.UserName,
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if(result.Succeeded)
            {
                //_obServerObject.NotifyObServer(appUser);
                return View();
            }

            //kayıt işleminden sonra return ile tanımlanan değişken dönülmez o değişken 
            //ile sadece kayıt işleminde key değeri sağlanır
            return View();
        }
    }
}
