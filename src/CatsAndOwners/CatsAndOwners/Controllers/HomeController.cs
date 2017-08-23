using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CatsAndOwners.Services;

namespace CatsAndOwners.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var p = new PetOwnerRetrievalService();
            await p.GetPetsOwnersAsync();

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
    }
}