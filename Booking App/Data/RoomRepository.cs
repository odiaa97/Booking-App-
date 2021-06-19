using Booking_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.Data
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Room_Type> GetRoomTypes()
        {
            return _context.Room_Types.ToList();
        }

        public Room GetRoom(int id)
        {
            return _context.Rooms.Find(id);
        }
        public Room Add(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }
    }
}
