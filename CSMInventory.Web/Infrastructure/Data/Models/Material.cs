using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class Material : BaseModel
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

    }
}
