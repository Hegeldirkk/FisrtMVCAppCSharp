using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FisrtMVCAppCSharp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FisrtMVCAppCSharp.Controllers
{
    public class HotelBookingController : Controller
    {

        private static readonly List<HotelBookingModel> hotels = new List<HotelBookingModel>();
        // GET: /<controller>/
        public IActionResult Index()
        {
            HotelBookingModel hotelBooking = new HotelBookingModel()
            { id=10,GuestName = "Ibis", DateStart=DateTime.Today, DateEnd=DateTime.Today.AddDays(3)};
            hotels.Add(hotelBooking);
            //return View("HotelBookingDetails");
            return RedirectToAction(nameof(HotelBookingDetails));
        }

        public IActionResult HotelBookingDetails()
        {
            return View(hotels);
        }
    }
}

