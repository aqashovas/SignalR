using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using queue.Models;
namespace queue.Controllers
{
    public class HomeController : Controller
    {
        private readonly QueueContext db = new QueueContext();
        public ActionResult Index()
        {
            List<Company> companies = db.Companies.ToList();
            return View(companies);
        }

      
    }
}