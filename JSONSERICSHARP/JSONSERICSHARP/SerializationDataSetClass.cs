﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
namespace JSONSERICSHARP
{
    class SerializationDataSetClass
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("dataSet");
            dataSet.Namespace = "NetFrameWork";
            DataTable table = new DataTable();
            DataColumn idColumn = new DataColumn("id", typeof(int));
            idColumn.AutoIncrement = true;

            DataColumn itemColumn = new DataColumn("item");
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);
            dataSet.Tables.Add(table);

            for (int i = 0; i < 2; i++)
            {
                DataRow newRow = table.NewRow();
                newRow["item"] = "item " + i;
                table.Rows.Add(newRow);
            }

            dataSet.AcceptChanges();

            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);

            Console.WriteLine(json);
            Console.Read();
        }
    }
}
