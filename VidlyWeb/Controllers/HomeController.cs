using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWeb.Models;
using VidlyWeb.ViewModels;
namespace VidlyWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Customer()
        {
            var cust = new Customers() { Id = 1, Name = "Narendra" };
            return View(cust);
        }
        public ActionResult Movie()
        {
            var cust = new Customers() { Id = 1, Name = "Narendra" };
            var Movies = new List<Movies>()
            {
                new Movies { Id=1,Name="Jumanji"},
                new Movies { Id=2,Name="Wall-E" }
            };
            var MovieViewModel = new MovieViewModel()
            {
                Customer = cust,
                Movies = Movies
            };


            return View(MovieViewModel);
        }
        public ActionResult MovieEdit(int Id)
        {
            var movie = new Movies();
            if (Id == 1)
                return Content(string.Format("Name=Jumanji"));
            if (Id == 2)
                return Content("Name=Wall-E");

            return View();
        }
    }
}