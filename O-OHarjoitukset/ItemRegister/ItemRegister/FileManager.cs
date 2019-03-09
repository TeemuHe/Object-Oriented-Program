using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
                    Console.WriteLine();
                    Console.WriteLine($"Nimi: {i.Name}\nItem number: {i.Id}\nGroup name: {i.GroupName}");
                }

                Console.WriteLine();

                Console.WriteLine("Tulostetaanko yhden tietyn tuotteen tiedot? K/E");
                string response = Console.ReadLine().ToUpper();
                if (response == "K")
                {
                    Console.WriteLine("Syötä tuotenumero(id): ");
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
                        Console.WriteLine("Virheellinen syöte");
                    }
                }
                else
                {
                    Console.WriteLine("Ei tuotteita");
                }
            }

            return "";
        }

        public string PrintGroup(string group)
        {
            //First creating a list
            List<Items> items = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));

            foreach (Items i in itemsList)
            {
                if (group == i.Id)
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
            }

            foreach (Items i in items)
            {
                if(group == "1" && i.GroupName == "Lajittelu ja säilytys")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
                else if(group == "2" && i.GroupName == "Paperit ja lehtiöt")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
                else if (group == "3" && i.GroupName == "Kynät")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
                else if (group == "4" && i.GroupName == "Kortit ja kirjekuoret")
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte");
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
            return "";
        }

        public void RanOutItems()
        {
            //First creating a list
            List<Items> items = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this.filePath));
            foreach (Items i in itemsList)
            {
                if(i.Amount == 0)
                {
                    Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}\tHinta: {i.Price}\nMäärä: {i.Amount}" +
                        $"Kommentti: {i.Comment}");
                }
            }
        }

        //public void InsertJson()
        //{
        //    try
        //    {
        //        StreamReader r = new StreamReader(filePath);
        //        string json = r.ReadToEnd();
        //        itemsList = JsonConvert.DeserializeObject<List<Items>>(json);
        //        PrintJson();
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Virhe: {e.Message}");
        //    }
        //}

        //public void PrintJson()
        //{
        //    foreach (Items i in itemsList)
        //    {
        //        Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}");
        //    }
        //}
    }
}
