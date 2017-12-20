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
        private DbContext context;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GotBlood.Models.ApplicationDbContext context)
        {
            var adminRole = new IdentityRole("Admin");
            context.Roles.AddOrUpdate(r => r.Name, adminRole);

            context.SaveChanges();

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser
            {
                FirstName = "ellis",
                LastName = "thomas",
                Address = "304 NSS Ln",
                Location = "Nash, TN 37211",
                Phone = "555-555-5555",
                Birthdate = new DateTime(1980, 11, 08),
                UserName = "thomas",
                Email = "ellis@thomas.com",
                Type = 0,
            };

            userManager.CreateAsync(user, "123456").Wait();
            //userManager.AddToRoleAsync(user.Id, "Admin").Wait();

            context.BloodBank.AddOrUpdate(
                x => x.BloodBankStreetAddress,
                new DataModels.BloodBank
                {
                    BloodBankName = "Nashville Platelet Donation Center",
                    BloodBankStreetAddress = "2201 Charlotte Ave",
                    BloodBankCity = "Nashville",
                    BloodBankState = "TN",
                    BloodBankZip = "37203",
                    BloodBankPhone = "333-333-3333"
                },
                new DataModels.BloodBank
                {
                    BloodBankName = "Nashville Blood Donation Center",
                    BloodBankStreetAddress = "2201 Charlotte Ave",
                    BloodBankCity = "Nashville",
                    BloodBankState = "TN",
                    BloodBankZip = "37203",
                    BloodBankPhone = "333-333-3333"
                },
                new DataModels.BloodBank
                {
                    BloodBankName = "Nashville Zoo",
                    BloodBankStreetAddress = "3777 Nolensville Rd",
                    BloodBankCity = "Nashville",
                    BloodBankState = "TN",
                    BloodBankZip = "37211",
                    BloodBankPhone = "333-333-3333"
                },
                new DataModels.BloodBank
                {
                    BloodBankName = "Bridgestone Arena Nashville Predators",
                    BloodBankStreetAddress = "501 Broadway",
                    BloodBankCity = "Nashville",
                    BloodBankState = "TN",
                    BloodBankZip = "37203",
                    BloodBankPhone = "333-333-3333"
                }
            );
        }
    }
}
