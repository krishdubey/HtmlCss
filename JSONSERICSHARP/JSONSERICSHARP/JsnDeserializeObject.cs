using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace JSONSERICSHARP
{ 
    class JsnDeserializeObject
    {
       public void test1()
        {
           // ClassColl1 obj = new ClassColl1();
            Account account = JsonConvert.DeserializeObject<Account>(ClassColl1.json);

            Console.WriteLine(account.Email);

        }
    }
}
