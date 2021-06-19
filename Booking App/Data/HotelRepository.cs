using Booking_App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.Data
{
    public class HotelRepository : IHotelRepository
    {
        private readonly ApplicationDbContext _context;
        public HotelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetHotel(int id)
        {
            return _context.Hotels.Find(id);
        }
    }
}
