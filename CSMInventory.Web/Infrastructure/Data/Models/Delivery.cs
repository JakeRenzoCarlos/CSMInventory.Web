using CSMInventory.Web.Infrastructure.Data.Enums;
using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class Delivery : BaseModel
    {
        public DateTime Date { get; set; }

        public Status Status { get; set; }
    }
}
