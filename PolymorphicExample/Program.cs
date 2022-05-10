using PolymorphicExample.Databases;
using System;

namespace PolymorphicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.InterfaceOrientedProgrammingExample();
        }

        private void InterfaceOrientedProgrammingExample()
        {
            var mongoDb = new MongoDbConnection();
            var sqlServerDb = new SqlServerConnection();
            var whateverDb = new WhateverDbConnection();

            var db = new Database(mongoDb);
            db.OpenConnection();
            db.CloseConnection();

            db = new Database(sqlServerDb);
            db.OpenConnection();
            db.CloseConnection();

            db = new Database(whateverDb);
            db.OpenConnection();
            db.CloseConnection();

        }
    }
}
