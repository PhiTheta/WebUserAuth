using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserAuth.Controllers
{


	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            ViewBag.IsAdmin = User.IsInRole("Admin"); 
			return View();
		}

        [Authorize(Roles="Admin")]
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