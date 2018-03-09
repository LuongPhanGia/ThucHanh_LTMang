using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry iPHostEntry = Dns.Resolve(hostName);
            Console.WriteLine(iPHostEntry.HostName);
            foreach(IPAddress s in iPHostEntry.AddressList)
            {
                Console.WriteLine(s);
            }

       
        }
    }
}
