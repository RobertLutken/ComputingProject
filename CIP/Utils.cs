using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace CIP
{
    class Utils
    {

        static public int isInt(TextBox tb)
        {
            string value = tb.Text;
            int myNumber = 0;

            if (!string.IsNullOrEmpty(value))
            {
                int.TryParse(value, out myNumber);
                if (myNumber > 0)
                {
                    return myNumber;
                }
            }
            return -1;
        }

       static public string GetTOD()
        {
            DateTime dt = DateTime.Now;
            string dtFormat = "\t   HH:mm tt\ndd-MM-yyyy\n";
           return  dt.ToString(dtFormat);
        }
      static public string GetLocalIPAddress()
       {
           IPHostEntry host;
           string localIP = "";
           host = Dns.GetHostEntry(Dns.GetHostName());
           foreach (IPAddress ip in host.AddressList)
           {
               if (ip.AddressFamily == AddressFamily.InterNetwork)
               {
                   localIP = ip.ToString();
                   break;
               }
           }
           return localIP;
       }
    }
}
