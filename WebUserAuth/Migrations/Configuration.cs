namespace WebUserAuth.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using WebUserAuth.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebUserAuth.DataAccessLayer.DataAccess>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebUserAuth.DataAccessLayer.DataAccess context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

			context.Datas.AddOrUpdate(
			  new Data { MyKey = 1, MyName = "Mike1" },
			  new Data { MyKey = 2, MyName = "Mike2" },
			  new Data { MyKey = 3, MyName = "Mike3" }
			);
        }
    }
}
