using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloClient.RemoteHelloReference;

namespace HelloClient
{
    class Program
    {
        static RemoteHelloReference.IHelloService helloObj = new HelloServiceClient();

        static void Main(string[] args)
        {
            Console.WriteLine(helloObj.SayHello());
            Console.ReadLine();
        }
    }
}
