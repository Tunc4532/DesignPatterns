using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Design_RepositoryPattern.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ICatagoryService _service;

        public CatagoryController(ICatagoryService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var values = _service.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCatagory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCatagory(Catagory catagory)
        {
            _service.TInsert(catagory);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCatagory(int id)
        {
            var value = _service.TGetById(id);
            _service.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCatagory(int id)
        {
            var values = _service.TGetById(id);
            return View(id);
        }
        [HttpPost]
        public IActionResult EditCatagory(Catagory catagory)
        {
            _service.TUpdate(catagory);
            return RedirectToAction("Index");
        }

    }
}
