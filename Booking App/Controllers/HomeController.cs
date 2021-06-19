using Booking_App.Data;
using Booking_App.Entities;
using Booking_App.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Booking_App.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IHotelRepository _hotelRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationsRepository;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, 
                                IHotelRepository hotelRepository, 
                                IRoomRepository roomTypesRepository,
                                IReservationRepository reservationsRepositroy,
                                UserManager<ApplicationUser> userManager,
                                ApplicationDbContext context)
        { 
            _logger = logger;
            _hotelRepository = hotelRepository;
            _roomRepository = roomTypesRepository;
            _reservationsRepository = reservationsRepositroy;
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hotels = _hotelRepository.GetHotels();
            //ViewBag.Hotels = hotels;
            return View(hotels);
        }

        [HttpGet]
        public IActionResult Book(int id)
        {
            Console.WriteLine("Book api");
            var hotel = _hotelRepository.GetHotel(id);
            var room_types = Enum.GetValues(typeof(RoomTypes)); //_roomRepository.GetRoomTypes();
            BookRoomViewModel model = new BookRoomViewModel
            {
                Hotel_Id = hotel.Id,
                Hotel_Name = hotel.Name,
                Room_Types = (IEnumerable<RoomTypes>)room_types,
            };
            return View(model);
        }

       // [Authorize]
        [HttpPost]
        public IActionResult Book(BookRoomViewModel model, int id)
        {

            Room room = new Room()
            {
                Type = ((RoomTypes)Convert.ToDouble(Request.Form["Room_Type"])).ToString(),
                Booked = true,
                Price = Convert.ToDouble(Request.Form["Room_Type"].ToString()),
            };
            Room createdRoom = _roomRepository.Add(room);

            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser appuser = _context.AppUsers.Find(userid);

            Reservation reservation = new Reservation()
            {
                User = appuser,
                Hotel_ = _hotelRepository.GetHotel(id),
                Room_ = _roomRepository.GetRoom(createdRoom.Id),
                From = DateTime.ParseExact(Request.Form["from"].ToString(), "MM/dd/yyyy", null),
                To = DateTime.ParseExact(Request.Form["to"].ToString(), "MM/dd/yyyy", null),
                No_Rooms = model.No_Rooms   
            };
            _reservationsRepository.Add(reservation);
            return View(model);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
