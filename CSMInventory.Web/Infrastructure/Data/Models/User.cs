using CSMInventory.Web.Infrastructure.Data.Enums;
using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class User : BaseModel
    {
          public string UserName { get; set; }
        
          public string Password { get; set; }

          public LoginStatus LoginStatus { get; set; }
    }
}
