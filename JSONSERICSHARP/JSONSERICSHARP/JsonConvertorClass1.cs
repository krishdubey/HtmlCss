﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
namespace JSONSERICSHARP
{
    class JsonConvertorClass1
    {
        static void Main(string[] args)
        {
            List<StringComparison> stringComparisons = new List<StringComparison>
{
    StringComparison.CurrentCulture,
    StringComparison.Ordinal
};

            string jsonWithoutConverter = JsonConvert.SerializeObject(stringComparisons);

            Console.WriteLine(jsonWithoutConverter);
            // [0,4]

            string jsonWithConverter = JsonConvert.SerializeObject(stringComparisons, new StringEnumConverter());

            Console.WriteLine(jsonWithConverter);
            // ["CurrentCulture","Ordinal"]

            List<StringComparison> newStringComparsions = JsonConvert.DeserializeObject<List<StringComparison>>(
                jsonWithConverter,
                new StringEnumConverter());

            Console.WriteLine(string.Join(", ", newStringComparsions.Select(c => c.ToString()).ToArray()));
            // CurrentCulture, Ordinal
            Console.Read();
        }
    }
}
