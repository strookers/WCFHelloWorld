using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HelloServer;

namespace WcfHelloService
{
    class HelloService : IHelloService
    {
         private static IHelloWorld helloObj = new HelloWorld();

        public string SayHello()
        {
            return helloObj.SayHello();
        }
    }
   
}
