using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public bool Booked { get; set; }
        public int Number { get; set; }
    }
}
