using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models.Database.Entity
{
    public class AdvertiserinfoADinfoModel : AdvertiserinfoModel
    {
        public List<ADinfoModel> ADinfos { get; set; }

        public AdvertiserinfoADinfoModel()
        {
            ADinfos = new List<ADinfoModel>();
        }
    }
}