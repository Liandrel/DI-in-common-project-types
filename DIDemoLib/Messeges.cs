﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemoLib
{
    public class Messeges : IMesseges
    {
        public string SayHello() => "Hello Viewer";

        public string GoodBye() => "GoodBye";
    }

}