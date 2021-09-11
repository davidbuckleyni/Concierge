using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
   public class Tables
    {
        public int Id { get; set; }

        public string? Name {  get; set; }

        public string? Description {  get; set; }

        public string? Type {  get; set; }
        public int? Seats { get; set; }
        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

    }
}
