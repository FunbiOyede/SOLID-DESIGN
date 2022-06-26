using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.S
{
    public class BookingReservationGood
    {
        //search for hotels
        //check availability of the hotel
        //save booking infor to db
        //booking confirmation email


        private readonly Booking _booking;
        private readonly BookingDB _bookingDb;
        private readonly BookingConfirmationSender _bookingConfirmationSender;
        private readonly Hotels _hotels;


        public BookingReservationGood(Booking booking, BookingDB bookingDB,
            BookingConfirmationSender bookingConfirmationSender, Hotels hotels)
        {
            _bookingConfirmationSender = bookingConfirmationSender;
            _booking = booking;
            _bookingDb = bookingDB;
            _hotels = hotels;
        }
        public void Reservations()
        {
            _hotels.SearchHotels("Grand Budapest Hotels");
            _booking.GetHotelAvailabilityStatus("Grand Budapest Hotels");
            _bookingDb.SaveBookingToDb();
            _bookingConfirmationSender.SendBookingConfirmation("Grand Budapest Hotels");
        }













    }


    public class Booking
    {
        public void GetHotelAvailabilityStatus(string hotelName) { }
    }

    public class BookingDB
    {
        public void SaveBookingToDb() { }

    }

    public class BookingConfirmationSender
    {
        public void SendBookingConfirmation(object booking) { }
    }



    public class Hotels

    {
        public void SearchHotels(string queryString) { }

    }
}
