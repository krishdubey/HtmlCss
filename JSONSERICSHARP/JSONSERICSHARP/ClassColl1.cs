using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONSERICSHARP
{
    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
   public class ClassColl1
    {
        public static string json;
        
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                   "User",
                   "Admin"
                }
            };

            json = JsonConvert.SerializeObject(account, Formatting.Indented);
            

            Console.WriteLine(json);
            JsnDeserializeObject v1 = new JsnDeserializeObject();
            v1.test1();
            Console.Read();
        }
    }
}
