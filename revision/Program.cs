using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    class Program
    {
        public static void createlist()
        {
            List<string> create = new List<string>();
            create.Add("here we are creating sample string list");
            create.Add("and we are adding sample data");

        }
        public static void fetchlist()
        {
            List<string> samplelist = new List<string>();
            samplelist.Add("here we are again adding sample string data for testing");
            foreach (var item in samplelist)
            {
                Console.WriteLine(item);
            }
        }
        public static void listmethods()
        {
            List<int> mynums = new List<int>();
            mynums.Add(12);
            mynums.Add(20);
            mynums.Add(13);
            mynums.Add(40);
            mynums.Add(50);

            Console.WriteLine(mynums.Sum());
            foreach (var item in mynums)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            listmethods();
            Console.ReadLine();
        }
    }
}
