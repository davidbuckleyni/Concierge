using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Concierge.BAL.Enums;

namespace Concierge.Models
{
    public class Rooms
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Sleeps { get; set; }

        public Rooms? AdjacentRooms { get; set; }
        
        public  ICollection<Bed>? Beds { get; set; }

        public  ICollection<Amenitie>? Amenities {  get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }

        public DateTime? LastModifiedBy { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
