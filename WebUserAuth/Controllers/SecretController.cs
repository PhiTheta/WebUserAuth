using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserAuth.Controllers
{
//	[Authorize(Roles = "admin, sales")] // Auth for class
	[Authorize(Users = "user@mail.com")] // Auth for class
	public class SecretController : Controller
    {
		//[Authorize] // Only for one Action
		public ContentResult Secret()
		{
			return Content("This is a secret.......");
		}

		[AllowAnonymous] // When using Auth for class
		public ContentResult Overt()
		{
			return Content("This is not a secret.......");
		}
    }
}