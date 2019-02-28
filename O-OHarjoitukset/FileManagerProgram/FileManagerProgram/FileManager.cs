using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FileManagerProgram;
using Newtonsoft.Json;

namespace Example
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
        private List<Movie> movieList;

        public FileManager(string filePath)
        {
            this.filePath = @"C:\\temp\movie.Json";
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

            //File.WriteAllText(@"C:\\temp\movie.Json", JsonConvert.DeserializeObject(movie));

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }

        public void Json()
        {
            try
            {
                StreamReader x = new StreamReader(filePath);
                string json = x.ReadToEnd();
                movieList = JsonConvert.DeserializeObject<List<Movie>>(json);

                foreach (Movie m in movieList)
                {
                    Console.WriteLine($"Elokuvan nimi: {m.Name}\tVuosi:: {m.Year}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Tapahtui errori : {e.Message}");
            }
        }
    }
}
