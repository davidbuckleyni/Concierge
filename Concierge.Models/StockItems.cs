using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class StockItems
    {
        public int Id { get; set; }


        public string? BarCode { get; set; }
        public string? StockCode { get; set; }

        public string? Name {  get; set; }


        public string? Description {  get; set; }

        public int? Type {  get; set; }

        public int? lISTPrice { get; set; }
        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }

    }
}
