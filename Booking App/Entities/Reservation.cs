using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }
        public Room Room_ { get; set; }
        public Hotel Hotel_ { get; set; }
        public int No_Rooms { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
