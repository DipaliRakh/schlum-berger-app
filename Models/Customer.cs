using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Schlumberger.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string PrimaryContact { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }

        public string CustomerCategoryName { get; set; }

    }
}
