using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGN.L
{

    // a derived class should be able to replace the base class without any issue
    internal class Liksov
    {
        public void EntryPoint()
        {
            JSONConnection conn = new JSONConnection();
            conn.GetConnectionString();
            XMLConnection xmlConn = new XMLConnection();
            xmlConn.GetConnectionString();
        }
    }


    //base class
    public abstract class FormatConnectionParameters

    {

        public abstract void GetConnectionString();

    }

    //derived
    public class JSONConnection : FormatConnectionParameters
    {
        public override void GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }

    //derived
    public class XMLConnection : FormatConnectionParameters
    {
        public override void GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }



}
