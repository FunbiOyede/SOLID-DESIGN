using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.D
{

    //This principle of Dependency Inversion (DI) in Solid Principles is also known as Inversion of control (IoC). This principle was initially called IoC, but Martin Fowler coined the name DI
    //i.e. Dependency Injection or Dependency Inversion.
    //Loose coupling between High level modules and low level modules
    internal class DI
    {
        IOrder _order;
        public DI(IOrder order)
        {
            _order = order;

        }



        void LogOrder()
        {
            _order.Save();
        }
    }


    public interface IOrder
    {
        void Save();
        void Delete();
    }


    public class OrderService : IOrder
    {
        void IOrder.Delete()
        {
            throw new NotImplementedException();
        }

        void IOrder.Save()
        {
            throw new NotImplementedException();
        }
    }
}
