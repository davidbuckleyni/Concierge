using Concierge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Dal.Extensions
{
    public static class ConciergeExtensions
    {


        public static IQueryable<Rooms> GetAllRooms(this DbSet<Rooms> rooms)
        {
            return rooms;

        }
        public static Rooms GetSingleRoom(this DbSet<Rooms> rooms, int Id)
        {
            return rooms.Where(w => w.Id == Id).FirstOrDefault();
        }


    }
}
