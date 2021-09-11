using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Concierge.BAL.Enums;

namespace Concierge.Models
{
   public class Contact
    {

        public int Id { get; set; }


        public ContactTypeEnum? MyProperty { get; set; }
        public string? StringValue { get; set; }

        public int? NumberValue { get; set; }

        public int? Order { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
