namespace Identety.Migrations
{
    using Identety.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Identety.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Identety.Models.ApplicationDbContext";
        }

        protected override void Seed(Identety.Models.ApplicationDbContext context)
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

            //var _db = new ApplicationDbContext();
            //var _rm = new RoleStore<IdentityRole>(_db);
            //var _RoleManager = new RoleManager<IdentityRole>(_rm);

            //_RoleManager.Create(new IdentityRole("User"));
            // roleManager.Delete( roleManager IdentityRole("User"));

        }
    }
}
