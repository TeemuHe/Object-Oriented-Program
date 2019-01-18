using System;
using System.Collections.Generic;
using System.Text;

namespace TicketProgram
{
    class TicketClass
    {
        public int age;
        public string choise = null;
        string text = "";
        public double ticketPrice = 16;

        public void Customer()
        {
            Console.Write("Syötä ikäsi: ");
            age = int.Parse(Console.ReadLine());
            if (age < 7)
            {
                double discount1 = 1;
                Console.WriteLine($"Lippusi hinta on {ticketPrice - ticketPrice * discount1:F2} €");
            }
            else if (age >= 65)
            {
                double discount2 = 0.5;
                Console.WriteLine($"Lippusi hinta on {ticketPrice - ticketPrice * discount2:F2} €");
            }
        }

        public void Discount()
        {

            while (age < 64 && age >= 7)
            {
                choise = UserInterface();

                switch (choise)
                {
                    case "1":
                        double discount3 = 0.15;
                        text = $"Lippusi hinta on {ticketPrice - ticketPrice * discount3:F2} €";
                        break;
                    case "2":
                        double discount4 = 0.5;
                        text = $"Lippusi hinta on {ticketPrice - ticketPrice * discount4:F2} €";
                        break;
                    case "3":
                        double discount5 = 0.45;
                        text = $"Lippusi hinta on {ticketPrice - ticketPrice * discount5:F2} €";
                        break;
                    case "4":
                        double discount6 = 0.6;
                        text = $"Lippusi hinta on {ticketPrice - ticketPrice * discount6:F2} €";
                        break;
                    case "5":
                        double discount7 = 0;
                        text = $"Lippusi hinta on {ticketPrice - ticketPrice * discount7:F2} €";
                        break;
                    default:
                        text = "Virheellinen syöte. Yritä uuestaan.";
                        break;
                }
                Console.WriteLine(text);
                Environment.Exit(1);
            }
        }
        public string UserInterface()
        {
            Console.WriteLine("[1] MTK:n jäsen\n[2] Varusmies\n[3] Opiskelija\n[4] MTK:n jäsen sekä opiskelija\n[5] Ei mikään yllämainituista");
            Console.Write("Valitse mihin ryhmään kuulut: ");
            return Console.ReadLine();
        }
    }
}
