using DesignPattern.TempleteMethod.TempletePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TempleteMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(69.99);
            ViewBag.v4 = netflixPlans.Content("Flim-Dizi");
            ViewBag.v5 = netflixPlans.Resolation("480px");
            return View();
        }

        public IActionResult StandartPlan()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(94.99);
            ViewBag.v4 = netflixPlans.Content("Flim-Dizi-Belgesel");
            ViewBag.v5 = netflixPlans.Resolation("720px");
            return View();
        }
    }
}
