using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.I
{
    internal class InterfaceSeggregationBad
    {
    }

    //new requirement save to different database destination e.g redis, cassandra or amazon s3

    public interface IBookingSaver
    {
        void Save(string destination, object bookingInfo);
        void DeleteFromCache(string destination);
    }

    //clearly bookingDB doesnt need the DeeleteFromCachemethod
    //solution seperate interface
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
}
