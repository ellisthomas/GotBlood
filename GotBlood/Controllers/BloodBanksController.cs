using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using GotBlood.Models;
using GotBlood.Providers;
using GotBlood.Results;
using System.Data.Entity;
using GotBlood.DataModels;


namespace GotBlood.Controllers
{
    public class BloodBanksController
    {

        //GET api/BloodBanks
        [Route("BloodBanks")]
        public IEnumerable<BloodBank> GetBloodBanks()
        {
            var db = new ApplicationDbContext();
            var banks = db.BloodBank;
            return banks;
        }

    }
}