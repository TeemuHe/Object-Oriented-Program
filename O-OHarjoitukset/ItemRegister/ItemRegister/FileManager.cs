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

        public string ReadWords()
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
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Kyseistä tiedostoa ei löydy!");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            //Console.WriteLine("directoryName: " + directoryName);
            //Console.WriteLine("fileName: " + fileName);
            //Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = JsonConvert.DeserializeObject<List<Items>>();
            //string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }

        public void InsertJson()
        {
            try
            {
                StreamReader r = new StreamReader(filePath);
                string json = r.ReadToEnd();
                itemsList = JsonConvert.DeserializeObject<List<Items>>(json);
                PrintJson();
            }

            catch (Exception e)
            {
                Console.WriteLine($"Virhe: {e.Message}");
            }
        }

        public void PrintJson()
        {
            foreach (Items i in itemsList)
            {
                Console.WriteLine($"Tuote: {i.Name}\tTuotenumero: {i.Id}\tTuoteryhmä: {i.GroupName}");
            }
        }
    }
}
