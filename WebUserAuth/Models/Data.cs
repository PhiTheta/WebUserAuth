using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUserAuth.Models
{
	public class Data
	{
		[Key]
		public int MyKey { get; set; }
		public string MyName { get; set; }
	}
}