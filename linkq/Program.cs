using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkq
{
    class Program
    {
        public static void linq_pract()
        {
            int[] mynums = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var i = from a in mynums where a > 20 orderby a descending select a;

            string[] mystring = { "ravi", "umesh", "omkar", "ganesh", "mohit", "vyankatesh" };
            var x = from name in mystring where name.StartsWith("r") select name;
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            linq_pract();
            Console.ReadLine();
        }
    }
}
