using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myarraylist
{
    class Program
    {
        public static void marraylist()
        {
            ArrayList mydata = new ArrayList();
            mydata.Add("this is sample data");
            mydata.Add(101);
            mydata.Add("name : raviprasad sathe");
            mydata.Add('R');
          
            
            mydata.Insert(4, "hello this string is inserted");

            Console.WriteLine(mydata.IsFixedSize);
            Console.WriteLine("--------------------");
            foreach (var item in mydata)
            {
                Console.WriteLine(item);
                

            }
            
        }
        public static void myhashtable()
        {
            Hashtable mydata = new Hashtable();
            mydata.Add("name", "raviprasad");
            mydata.Add("address", "mohol,solapur");
            mydata.Add("mob", 9145557031);
            mydata.Add("pincode", 413213);
            Console.WriteLine(mydata["name"]);
            Console.WriteLine("----------------------");
            foreach (object data in mydata.Keys)
            {
                Console.WriteLine(data+" :  "+ mydata[data]);
            }
            Console.WriteLine("----------------");
            Console.WriteLine("mob".GetHashCode());
            
          
        }
        static void Main(string[] args)
        {

            myhashtable();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
