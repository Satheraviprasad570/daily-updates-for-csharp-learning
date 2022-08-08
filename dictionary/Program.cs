using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        public static void dictcreate()
        {
            var mydict = new Dictionary<string, int>();
            mydict.Add("ravi", 011111);
            mydict.Add("suraj", 02);
            mydict.Add("akash",03);
            mydict.Add("rajkumar", 04);

            var dict = new Dictionary<int, string>()
            {
                {1,"raviprasad"},
                {2,"uday"},
                {3,"majanu"},
                {4,"sanju"},
                {5,"mauli"}

            };

            

        }
        public static void getvalue(){


            var mydict2 = new Dictionary<string, int>()
            {
                {"cat",1},
                {"dog",2},
                {"camel",3},
                {"goat",4},
                {"cow",5}

            };
            int value;
            mydict2.TryGetValue("cow",out value);

            Console.WriteLine("value returned is {0}",value);

        }
        public static void checkkey()
        {
            var mydict = new Dictionary<string, int>();
            mydict.Add("ravi", 011111);
            mydict.Add("suraj", 02);
            mydict.Add("akash", 03);
            mydict.Add("rajkumar", 04);

            if (mydict.ContainsKey("ravi"))
            {
                Console.WriteLine("key is found");
            }
            else
            {
                Console.WriteLine("key is not found");
            }

        }
        public static void checkvalue()
        {
            var sampledict = new Dictionary<string, string>()
            {
                {"what","what means what"},
                {"how","how means way of doing things"},
                {"when","when means time of doing things"},
                {"where","where means what is the location of these things"}
            };
            if (sampledict.ContainsValue("what means what"))
            {
                Console.WriteLine("value is present");
            }
            else
            {
                Console.WriteLine("value is not present in given dict");
            }
        }
        static void Main(string[] args)
        {
            checkvalue();
            Console.ReadLine();
        }
    }
}
