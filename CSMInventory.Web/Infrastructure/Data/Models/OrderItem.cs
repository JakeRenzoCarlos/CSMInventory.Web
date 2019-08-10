using CSMInventory.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMInventory.Web.Infrastructure.Data.Models
{
    public class OrderItem : BaseModel
    {
        public Guid? OrderId { get; set; }

        public Guid? ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
