using Acradis.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Acradis.API.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Nullable<decimal> Cost { get; set; }
        [Required]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }


        public Nullable<decimal> TotalCost { get; set; }

       




    }
}
