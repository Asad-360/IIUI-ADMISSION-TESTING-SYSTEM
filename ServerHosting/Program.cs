
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerHosting
{
    class Program
    {
       
        static void Main(string[] args)
        {
          
            using (ServiceHost host = new ServiceHost(typeof(ServerService)))
            {
                host.Open();
                Console.WriteLine($"The server started hosting at {DateTime.Now}");
                Console.ReadLine();
            }
        }
    }
}
