using PolymorphicExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicExample.Databases
{
    public class SqlServerConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Closed SQL Server connection.");
        }

        public void Open()
        {
            Console.WriteLine("Opened SQL Server connection.");
        }
    }
}
