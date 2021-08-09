using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Dal
{
    public class ConciergeDal
    {

        public ConciergeDBContext db { get; set; }
        public ConciergeDal(ConciergeDBContext dbContext)
        {
            db = dbContext;
        }

        public 
    }
}
