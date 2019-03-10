using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace ItemRegister
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {
        }
    }

    class FileManager
    {
        private string filePath;
        private List<Items> itemsList;

        public FileManager(string filePath)
        {
            this.filePath = @"C:\\temp\items.Json";
        }

        public string WholeList()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Items> itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));

                foreach (Items i in itemsList)
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"Nimi: {i.Name}\tItem number: {i.Id}\tGroup name: {i.GroupName}");
                }

                Console.WriteLine();

                Console.WriteLine("Tulostetaanko yhden tietyn tuotteen tiedot? K/E");
                string response = Console.ReadLine().ToUpper();
                if (response == "K")
                {
                    Console.Write("Syötä tuotenumero (id): ");
                    string inputId = Console.ReadLine();
                    bool found = false;

                    foreach (Items i in itemsList)
                    {
                        if (inputId == i.Id)
                        {
                            found = true;
                            Console.WriteLine($"Nimi: {i.Name}\nTuotenro: {i.Id}\nTuoteryhma: {i.GroupName}\nHinta: {i.Price}\nMaara: {i.Amount}\nKommentti: {i.Comment}\n");
                        }
                    }
                    if (found != true)
                    {
                        Console.WriteLine("Tällä tuotenumerolla ei löydy tuotetta");
                    }
                }
            }

            return "";
        }

        public string PrintGroup(string group)
        {
            //First creating a list
            List<Items> items = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));
            foreach (Items i in items)
            {
                if (group == "A" && i.GroupName == "Lajittelu ja säilytys")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"\tKommentti: {i.Comment}\n-----------------------");
                }
                else if (group == "B" && i.GroupName == "Paperit ja lehtiöt")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"\tKommentti: {i.Comment}\n-----------------------");
                }
                else if (group == "C" && i.GroupName == "Kynät")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"\tKommentti: {i.Comment}\n-----------------------");
                }
                else if (group == "D" && i.GroupName == "Kortit ja kirjekuoret")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"\tKommentti: {i.Comment}\n-----------------------");
                }
            }
            return "";
        }

        public string PrintItem()
        {
            //First creating a list
            List<Items> items = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));
            Console.Write("Syötä tuotteen tuotenumero: ");
            string idInput = Console.ReadLine();

            foreach (Items i in itemsList)
            {
                if (idInput == i.Id)
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
            }
            Console.ReadKey();
            return "";
        }

        public void RanOutItems()
        {
            //First creating a list
            List<Items> itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));
            foreach (Items i in itemsList)
            {
                if (i.Amount == 0)
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\nTuoteryhmä: {i.GroupName}\nHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"\nKommentti: {i.Comment}\n-----------------------");
                }
            }
        }

        public void AddComment()
        {
            //First creating a list
            List<Items> itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));
            Console.Write("Syötä tuotenumero, jolle halutaan lisätä kommetti: ");
            string commentedItem = Console.ReadLine();
            bool isReal = false;

            foreach (Items i in itemsList)
            {


                if (commentedItem == i.Id)
                {
                    isReal = true;

                    Console.Write("Syötä haluttu kommentti: ");
                    string comment = Console.ReadLine();

                    if (i.Comment != commentedItem)
                    {
                        i.Comment += comment;

                        File.WriteAllText(filePath, JsonConvert.SerializeObject(itemsList));
                        Console.WriteLine("Kommentti lisätty");
                    }
                    if (isReal != true)
                    {
                        Console.WriteLine("Tuotetta ei löydy");
                    }
                    else if (i.Comment == commentedItem)
                    {
                        Console.WriteLine("Älä syötä samaa kommenttia uudelleen");
                    }
                }
            }
        }
    }
}
