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
                double discount1 = 0;
                Console.WriteLine($"Lippusi hinta on {ticketPrice * discount1:F2} €");
            }
            else if (age >= 65)
            {
                double discount2 = 0.5;
                Console.WriteLine($"Lippusi hinta on {ticketPrice * discount2:F2} €");
            }
        }

        public void Discount()
        {
            if (age < 64 && age >= 7)
            {
                do
                {
                    choise = UserInterface();

                    switch (choise)
                    {
                        case "1":
                            double discount3 = 0.85;
                            text = $"Lippusi hinta on {ticketPrice * discount3:F2} €";
                            break;
                        case "2":
                            double discount4 = 0.5;
                            text = $"Lippusi hinta on {ticketPrice * discount4:F2} €";
                            break;
                        case "3":
                            double discount5 = 0.55;
                            text = $"Lippusi hinta on {ticketPrice * discount5:F2} €";
                            break;
                        case "4":
                            double discount6 = 0.4;
                            text = $"Lippusi hinta on {ticketPrice * discount6:F2} €";
                            break;
                        case "5":
                            double discount7 = 1.0;
                            text = $"Lippusi hinta on {ticketPrice * discount7:F2} €";
                            break;
                        default:
                            text = "Virheellinen syöte. Syötä uus.";
                            break;
                    }

                    Console.WriteLine(text);
                    Console.ReadLine();
                    Environment.Exit(1);
                } while (choise != "X");
            }
        }
        public string UserInterface()
        {
            Console.WriteLine("Valitse mihin ryhmään kuulut");
            Console.WriteLine("[1] MTK:n jäsen");
            Console.WriteLine("[2] Varusmies");
            Console.WriteLine("[3] Opiskelija");
            Console.WriteLine("[4] MTK:n jäsen sekä opiskelija");
            Console.WriteLine("[5] Ei mikään yllämainittu");
            return Console.ReadLine();
        }
    }
}
