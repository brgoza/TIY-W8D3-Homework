using Week8Day3.Models;

namespace Week8Day3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week8Day3.AppModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week8Day3.AppModel context)
        {
            context.PostDbSet.AddOrUpdate(x => x.Title,
                new Post() {Author = "Brandon G", Body = "Body 1", Title = "Title 1"},
                new Post() {Author = "Brandon G", Body = "Body 2", Title = "Title 2"},
                new Post() {Author = "Brandon G", Body = "Body 3", Title = "Title 3"},
                new Post() {Author = "Brandon G", Body = "Body 4", Title = "Title 4"});

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
        }
    }
}
