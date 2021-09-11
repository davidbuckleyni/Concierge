using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Concierge.BAL.Enums;

namespace Concierge.Models
{
   public  class SalesOrder
    {
        public int Id { get; set; }

      
        public SalesOrderTypeEnum? Type { get; set; }


        public int? Total { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate {  get; set;}
    }
}
