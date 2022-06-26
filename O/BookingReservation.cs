using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.O
{

    //open closed principle
    // a class should be opened for extension and closed for modification
    // basicall interface
    //extension from SingleResponsibility

    internal class BookingReservation
    {
    }


    public class Booking
    {
        public void GetHotelAvailabilityStatus(string hotelName) { }
    }
    //new requirement save to different database destination e.g redis, cassandra or amazon s3

    public interface IBookingSaver
    {
        void Save(string destination, object bookingInfo);
    }
    public class BookingDB : IBookingSaver
    {

        public void Save(string destination, object bookingInfo)
        {

        }
    }


    public class BookingCache : IBookingSaver
    {
        public void Save(string destination, object bookingInfo)
        {

        }

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
