using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
     public class Customer
    {

        public int? Id { get; set; }

        public string? FirstName { get; set; }

        public bool? PreviousCustomer { get; set; }

        public Person? Person { get; set; }
        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
