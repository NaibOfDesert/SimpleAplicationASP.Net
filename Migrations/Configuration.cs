namespace SimpleAplicationASP.Net.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleAplicationASP.Net.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        
        protected override void Seed(SimpleAplicationASP.Net.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(
            new Book(new Author("Tomasz", "Bielak"), "Jakaś książka", 2011, new Publisher("Wydawnictwo co")),
            new Book(new Author("Ola", "Fasola"), "Coś tam było", 2001, new Publisher("Wydawnictwo kto")),
             new Book(new Author("Jacek", "Posmak"), "Placek", 2011, new Publisher("Wtedy")),
            new Book(new Author("Iza", "Iza"), "Test2", 2001, new Publisher("Kiedy"))
            );
        }
    }
}
