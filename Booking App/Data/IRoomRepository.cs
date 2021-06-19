using Booking_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.Data
{
    public interface IRoomRepository
    {
       IEnumerable<Room_Type> GetRoomTypes();
        Room GetRoom(int id);
        Room Add(Room room);
    }
}
