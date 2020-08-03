using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acradis.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> Quantity { get; set; }

        public string Title { get; set; }


        //public Nullable<decimal> TotalCost { get; set; }
    }
}
