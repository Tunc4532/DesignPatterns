using DesignCompositePattern.CompositePattern;
using DesignCompositePattern.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignCompositePattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var catagories = _context.Catagories.Include(x => x.Products).ToList();
            var values = Rekursive(catagories, new Catagory { CatagoryName = "FirstCatagory", CatagoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Rekursive(List<Catagory> catagories, Catagory firstCatagory, ProductComposite firstComposite, ProductComposite? leaf = null)
        {
            catagories.Where(x => x.UpperCatagoryID == firstCatagory.CatagoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CatagoryID, y.CatagoryName);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });

                if (leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(catagories, y, firstComposite, productComposite);
            });

            return firstComposite;
        }

    }
}
