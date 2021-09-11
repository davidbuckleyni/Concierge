using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
   public  class Country
    {

        public int ID { get; set; }
        public int Code { get; set; }

        public string? IsoCode { get; set; }

        public string? Flag { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
