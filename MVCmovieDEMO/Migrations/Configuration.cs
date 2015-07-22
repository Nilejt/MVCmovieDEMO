namespace MVCmovieDEMO.Migrations
{
    using MVCmovieDEMO.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCmovieDEMO.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCmovieDEMO.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate( i => i.Title, 
                new Movies
                {
                   Title = "When Harry Met Sally",
                   ReleaseDate = DateTime.Parse("1989-1-11"),
                   Genre = "Romantic Comedy",
                   Rating = "PG",
                   Price = 7.99M
                 },

                new Movies
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },

                new Movies
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 9.99M
                },

                new Movies
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG-13",
                    Price = 3.99M
                }
                );

           
        }
    }
}
