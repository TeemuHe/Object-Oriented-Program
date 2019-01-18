using System;

namespace TicketProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Lippuhintaohjelma");

            TicketClass customer = new TicketClass();
            customer.Customer();
            customer.Discount();
        }
    }
}
