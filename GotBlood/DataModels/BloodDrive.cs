using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GotBlood.DataModels
{
    public class BloodDrive
    {
        public int Id { get; set; }
        public string BloodDriveName { get; set; }
        public string BloodDriveStreetAddress { get; set; }
        public string BloodDriveCity { get; set; }
        public string BloodDriveState { get; set; }
        public string BloodDriveZip { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
   
}