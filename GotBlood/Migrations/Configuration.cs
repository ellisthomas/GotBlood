namespace GotBlood.Migrations
{
    using GotBlood.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GotBlood.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GotBlood.Models.ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser
            {
                FirstName = "ellis",
                LastName = "thomas",
                Address = "304 NSS Ln",
                Location = "Nash, TN 37211",
                Phone = "555-555-5555",
                Birthdate = new DateTime(1980,11,08),
                UserName = "thomas",
                Email = "ellis@thomas.com",
                Type = 0,
            };

            userManager.CreateAsync(user, "123456").Wait();
        }
    }
}
