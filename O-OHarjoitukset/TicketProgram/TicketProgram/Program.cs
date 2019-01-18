using System;

namespace TicketProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Lippuohjelma");

            TicketClass customer = new TicketClass();
            customer.Customer();
            customer.Discount();
        }
    }
}
