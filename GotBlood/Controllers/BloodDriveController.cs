using GotBlood.DataModels;
using GotBlood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace GotBlood.Controllers
{

    public class BloodDriveController : ApiController
    {
        // POST api/BloodDrive
        [AllowAnonymous]
        [HttpPost,Route("api/BloodDrive")]
        public IHttpActionResult BloodDrive(BloodDrive model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var db = new ApplicationDbContext();
            db.BloodDrives.Add(model);
            db.SaveChanges();

            return Ok();
        }

        //GET api/BloodDrive
        [HttpGet, Route("api/GotBlood")]
        public IEnumerable<BloodDrive> GetBloodDrive()
        {
            var db = new ApplicationDbContext();
            var drives = db.BloodDrives;
            return drives;
        }




    }
}