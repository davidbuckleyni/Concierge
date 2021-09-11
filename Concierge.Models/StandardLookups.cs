using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class StandardLookups
    {
        public int Id { get; set; }


        public string? Name {  get; set; }

        public int? LookupGroup { get; set; }

        public int? LookupOrder {  get; set;}
        public string? Description {  get; set; }


        public string? StringValue { get; set; }

        public int? NumberValue { get; set; }

        public decimal? DecimalValue { get; set; }


        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }





    }
}
