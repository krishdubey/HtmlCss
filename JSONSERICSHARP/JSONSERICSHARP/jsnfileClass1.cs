using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace JSONSERICSHARP
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class jsnfileClass1
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie
            {
                Name = "Kriss",
                Year = 2010

            };
            File.WriteAllText(@"g:\\movie.json", JsonConvert.SerializeObject(movie));

            using (StreamWriter file = File.CreateText(@"g:\\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
