using PolymorphicExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicExample.Databases
{
    public class MongoDbConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Closed MongoDB connection.");
        }

        public void Open()
        {
            Console.WriteLine("Opened MongoDB connection.");
        }
    }
}
