using Concierge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concierge.Dal.Extensions;
namespace Concierge.Dal
{
    public class ConciergeDal
    {

        public ConciergeDBContext db { get; set; }
        public ConciergeDal(ConciergeDBContext dbContext)
        {
            db = dbContext;
        }

        public Rooms? GetSingleRoom(int roomId)
        {
            return db.Rooms.Where(w=>w.Id==roomId).FirstOrDefault();            
        }

     }
}
