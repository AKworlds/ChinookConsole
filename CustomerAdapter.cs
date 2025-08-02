using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;

namespace ChinookConsole
{
    public class CustomerAdapter
    {
        private string connectionString = @"Data Source=C:\Users\Kamad\Downloads\C# homework\Chinook_Sqlite_AutoIncrementPKs (4).sqlite;Version=3;";

        public IEnumerable<Customer> GetAll()
        {
            string sql = "SELECT CustomerId, FirstName, LastName, Country, Email FROM Customer";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<Customer>(sql);
            }
        }
    }
}