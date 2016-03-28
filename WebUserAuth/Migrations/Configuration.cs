namespace WebUserAuth.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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

            //context.

			context.Datas.AddOrUpdate(
			  new Data { MyKey = 1, MyName = "Mike1" },
			  new Data { MyKey = 2, MyName = "Mike2" },
			  new Data { MyKey = 3, MyName = "Mike3" }
			);

            SeedMembership();
        }

        private void SeedMembership()
        {
            var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
           
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("User"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var passwordHash = new PasswordHasher();

            if (!userManager.Users.Any(u => u.UserName == "admin@admin.net"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = passwordHash.HashPassword("123456")
                };

                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

        }
    }
}
