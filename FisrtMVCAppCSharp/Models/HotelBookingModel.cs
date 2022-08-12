using System;
namespace FisrtMVCAppCSharp.Models
{
    public class HotelBookingModel
    {
        public int id { get; init; }

        public string? GuestName { get; set; }

        public DateTime DateStart { get; init; }

        public DateTime DateEnd { get; init; }
    }
}

