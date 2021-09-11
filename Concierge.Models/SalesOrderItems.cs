using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Concierge.BAL.Enums;

namespace Concierge.Models
{
   public class SalesOrderItems
    {

        public int? Id { get; set; }


        public string? Name { get; set; }


        [StringLength(30, ErrorMessage = "The Barcode value cannot exceed 30 characters. ")]
        public string? BarCode { get; set; }

        public string? EAN { get; set; }
        
        [StringLength(1000, ErrorMessage = "The ShortDescription value cannot exceed 1000 characters. ")]
        public string? ShortDescription { get; set; }

        public string? Description { get; set; }

        public string? Qty { get; set; }

        public StockItems? StockItem { get; set; }

        public SalesOrderTypeEnum? Type { get; set; }


        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }

    }
}
