using AdventureWorksSales.Web.Context;
using AdventureWorksSales.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class HomeController : Controller
    {
        private DBContext context = new DBContext();
        public HomeController()
        {

        }
        public ActionResult Index()
        {

            var product = context.Products.AsQueryable().FirstOrDefault(p => p.Name == "Front Brakes");
            var model = new SummaryViewModel()
            {
                Totalorders = context.SalesOrders.AsQueryable().Sum(s => s.LineTotal).ToString(),
                HighestLineTotal = context.SalesOrders.AsQueryable().Max(s => s.LineTotal).ToString(),
                FrontBrakesSalesTotal = context.SalesOrders.AsQueryable().Where(s => s.ProductId == product.ProductId).Sum(s => s.LineTotal).ToString()
            };
            return View(model);
        }

    }
}