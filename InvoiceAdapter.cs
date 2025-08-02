using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;

namespace ChinookConsole
{
    public class InvoiceAdapter
    {
        private string connectionString = @"Data Source=C:\Users\Kamad\Downloads\C# homework\Chinook_Sqlite_AutoIncrementPKs (4).sqlite;Version=3;";

        public IEnumerable<Invoice> GetAll()
        {
            string sql = "SELECT InvoiceId, CustomerId, InvoiceDate, Total FROM Invoice";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<Invoice>(sql);
            }
        }
    }
}
