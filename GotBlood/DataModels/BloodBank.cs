using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GotBlood.DataModels
{
    public class BloodBank
    {
        public string BloodBankName { get; set; }
    
        public int Id { get; set; }
        [Required]
        public string BloodBankStreetAddress { get; set; }
        [Required]
        public string BloodBankCity { get; set; }
        [Required]
        public string BloodBankState { get; set; }
        [Required]
        public string BloodBankZip { get; set; }
        [Required]
        public string BloodBankPhone { get; set; }
        
  
    }
}