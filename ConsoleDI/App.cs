using DIDemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI
{
    public class App
    {
        private readonly IMesseges _messeges;

        public App(IMesseges messeges)
        {
            _messeges = messeges;
        }
        public void Run()
        {
            Console.WriteLine(_messeges.SayHello());
            Console.WriteLine(_messeges.SayGoodBye());
            Console.ReadLine();
        }
    }
}
