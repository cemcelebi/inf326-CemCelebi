namespace APIcem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using APIcem.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<APIcem.Models.damacanaapiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APIcem.Models.APIcemContext context)
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
            context.Products.AddOrUpdate(x => x.Id,
       new Product() { Id = 1, Name = "Erikli", Price = 5 },
       new Product() { Id = 2, Name = "Pinar", Price = 5 },
       new Product() { Id = 4, Name = "Sirma", Price = 5 },
       new Product() { Id = 3, Name = "Sirma19", Price = 5 });
        }
    }
}