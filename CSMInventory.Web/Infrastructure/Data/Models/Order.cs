using CSMInventory.Web.Infrastructure.Data.Enums;
using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class Order : BaseModel
    {
        public Guid? StudentId { get; set; }
   
        public Guid? UserId { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public Status Status { get; set; }

        public int RecieptNo { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
