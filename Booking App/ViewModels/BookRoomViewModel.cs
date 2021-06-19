using Booking_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_App.ViewModels
{
    public class BookRoomViewModel
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Hotel_Id { get; set; }
        public string Hotel_Name { get; set; }
        public IEnumerable<RoomTypes> Room_Types { get; set; }
        public int Room_Id { get; set; }
        public string Room_Type { get; set; }
        public int No_Rooms { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
