﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace JSONSERICSHARP
{
    class SerializationDictionaryClass
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>
            {
              { "James", 9001 },
              { "Jo", 3474 },
              { "Jess", 11926 }
            };

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json);
            Console.Read();
        }
    }
}
