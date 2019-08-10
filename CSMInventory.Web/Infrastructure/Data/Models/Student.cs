using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
