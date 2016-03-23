using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebUserAuth.Models;

namespace WebUserAuth.DataAccessLayer
{
	public class DataAccess : DbContext
	{
		public DataAccess() : base("DefaultConnection")
		{

		}

		public DbSet<Data> Datas { get; set; }
	}
}