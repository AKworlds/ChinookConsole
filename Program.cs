using System;

namespace ChinookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Display Customer data
                Console.WriteLine("Customer Data:\n");
                CustomerAdapter customerAdapter = new CustomerAdapter();
                var customers = customerAdapter.GetAll();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"CustomerId: {customer.CustomerId} FirstName: {customer.FirstName} LastName: {customer.LastName} Country: {customer.Country}");
                }

                // Display Invoice data
                Console.WriteLine("\nInvoice Data:\n");
                InvoiceAdapter invoiceAdapter = new InvoiceAdapter();
                var invoices = invoiceAdapter.GetAll();

                foreach (var invoice in invoices)
                {
                    Console.WriteLine($"InvoiceId: {invoice.InvoiceId} CustomerId: {invoice.CustomerId} InvoiceDate: {invoice.InvoiceDate} Total: {invoice.Total:C}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}