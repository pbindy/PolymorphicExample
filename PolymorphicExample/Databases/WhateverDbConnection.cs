using PolymorphicExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicExample.Databases
{
    public class WhateverDbConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Closed Whatever Db connection.");
        }

        public void Open()
        {
            Console.WriteLine("Opened Whatever Db connection.");
        }
    }
}
