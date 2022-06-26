using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.S
{
    public class BookingReservationBad
    {
        //search for hotels
        //check availability of the hotel
        //make payments
        //booking confirmation


        // classes should have a single responsibility

        public void SearchHotels(string queryString) { }

        public void GetHotelAvailabilityStatus(string hotelName) { }


        public void SaveBookingToDb() { }


        public void SendBookingConfirmation(object booking) { }
    }
}
