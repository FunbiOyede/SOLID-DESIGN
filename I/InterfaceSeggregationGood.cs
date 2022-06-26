using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.I
{
    internal class InterfaceSeggregationGood
    {
    }


    public interface IBookingSavers
    {
        void Save(string destination, object bookingInfo);

    }


    public interface ICacheSaver

    {
        void DeleteFromCache(string destination);

    }



    public class BookingDBs : IBookingSavers
    {

        public void Save(string destination, object bookingInfo)
        {

        }
    }


    public class BookingCaches : ICacheSaver
    {
        public void DeleteFromCache(string destinatio)
        {

        }

    }
}
