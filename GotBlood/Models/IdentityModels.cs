using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using GotBlood.DataModels;
using System.Collections.Generic;

namespace GotBlood.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        internal static object CreateAsync(ApplicationUser user, string v)
        {
            throw new NotImplementedException();
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Address { get; set; }
        public string Location { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public BloodType Type { get; set; }
        public object BloodType { get; set; }
    }

    public enum BloodType
    {
        Unknown,
        AB,
        A,
        B,
        O
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<BloodBank> BloodBank { get; set; }
        public DbSet<BloodDrive> BloodDrives { get; set; }

        public IEnumerable<ApplicationUser> BloodBanks { get; internal set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}