using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GotBlood.DataModels
{
    public class BloodDrive
    {
        public int Id { get; set; }
        public virtual BloodBank Location { get; set; }
        

    }
}