using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class Enums
    {
        public enum BuildingTypeEnum
        {
            Hotel=1,
            Apartment=2,
            Flat=3,
            Villa=4,           
        }

        public enum PersonTypeEnum
        {
             Owner=1,
             Subowner=2,
             Manager=3,
             StaffMember=4,
             Contractor=5,
             Cleaner=6,
             Maintainace=7,
        }

    }
    }
