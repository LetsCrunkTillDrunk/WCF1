using MyDisk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyDiskInfoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MyDiskInfo)))
            {
                host.AddServiceEndpoint(typeof(IMyDisk),new BasicHttpBinding(), "http://localhost:8021/MyDiscInfo");
                host.Open();
                Console.ReadKey(true);
            }
        }
    }
}
