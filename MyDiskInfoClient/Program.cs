using MyDisk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyDiskInfoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IMyDisk> factory = new ChannelFactory<IMyDisk>(new BasicHttpBinding(), "http://localhost:8021/MyDiscInfo");
            IMyDisk client = factory.CreateChannel();
            while (true)
            {
                Console.WriteLine("Введите название диска");
                string request = Console.ReadLine();
                Console.WriteLine(client.FreeSpace(request));
                Console.WriteLine(client.TotalSpace(request));
            }
        }
    }
}
