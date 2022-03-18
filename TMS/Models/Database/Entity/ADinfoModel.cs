using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models.Database.Entity
{
    public class ADinfoModel 
    {
        public int adid { get; set; }
        public string advertisename { get; set; }
        public string advertisetype { get; set; }
        public decimal advertisebudget { get; set; }
        public string contactno { get; set; }
        public int advertiserid { get; set; }

        public AdvertiserinfoModel Advertiserinfo { get; set; }

    }
}