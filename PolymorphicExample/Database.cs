using PolymorphicExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicExample
{
    public class Database
    {
        private readonly IConnection _connection;

        public Database(IConnection connection)
        {
            _connection = connection;
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}
