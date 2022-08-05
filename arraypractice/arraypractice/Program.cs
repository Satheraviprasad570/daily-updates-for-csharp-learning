using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraypractice
{
    class Program
    {
        public static void arrayindex()
        {
            int[] mynums = {1, 2, 3, 4, 5, 6, 7, 8, 9,10};
            int table;
            Console.WriteLine("enter table number you want to");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("here is your table");
            
            foreach(var i in mynums)
            {
               Console.WriteLine(i*table);
               
              
            }
            
        }
        public static void sortarray()
        {
            int[] nums = { 1, 3, 7, 6, 5, 3, 7, 1, 9, 10 };
            Array.Sort(nums);
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static void stringarray()
        {
            string [] mystring = new string[5];
            mystring = new string [] {Console.ReadLine()};
            foreach(var i in mystring)
            {
                Console.WriteLine(i);
            }
        }
        public static void declarearray()
        {
            string[] data = new string[] { "raju", "amit", "pawan", "ubed", "prashant" };
            Console.WriteLine( data.GetValue(4));


        }
        public static void collections()
        {
            var chars = new List<string>() { "hello there how are you","i am fine what about you" };
          
            foreach(var i in chars)
            {
                Console.WriteLine(i);
            }
 
        }
        static void Main(string[] args)
        {
            collections();
            Console.ReadLine();
        }
    }
}
