using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
       Product myProduct = new Product
       {
           ProductID = 1,
           Name = "Kayak",
           Description = "A boat for on person",
           Category = "Watersports",
           Price = 275M};
       
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(myProduct);
        }
<<<<<<< HEAD
        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

=======
 public ActionResult NameAndPrice()
        {
            return View();
        }
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

>>>>>>> 469356aa94fc4264299bbf570b276d00accc2bb9
            return View(myProduct);
        }
    }
}
