using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        public static void mylist()
        {
            List<string> mystring = new List<string>();
            mystring.Add("hello");
            mystring.Add("world");
            mystring.Add("how");
            mystring.Add("are");
            mystring.Add("you");
            Console.WriteLine(mystring.Capacity);   
            List<int> vs = new List<int>();
            vs.Add(11);
            vs.Add(22);
            vs.Add(33);
            vs.Add(44);
            vs.Add(55);

            foreach (int item in vs)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        //public static void complexlist()
        //{

        //    emp emp1 = new emp()
        //    {
        //        name = "raviprasad",
        //        age = 22,
        //        position= "developer"

        //    };
        //    emp emp2 = new emp()
        //    {
        //        name = "rohit",
        //        age = 23,
        //        position = "developer"  
        //    };
        //    emp emp3 = new emp()
        //    {
        //        name = "anushka",
        //        age = 21,
        //        position = "developer"
        //    };

        //    List<emp> emplist = new List<emp>();

        //    emplist.Add(emp1);
        //    emplist.Add(emp2);
        //    emplist.Add(emp3);

        //    foreach (emp item in emplist)
        //    {
        //        Console.WriteLine($"employee name is {item.name} age is {item.age} and position is {item.position}");
        //    }

        //}

        public static void listmethods()
        {
            List<int> mynums = new List<int>();
            mynums.Add(10);
            mynums.Add(11);
            mynums.Add(15);
            mynums.Add(13);
            mynums.Add(14);
            mynums.Add(15);
            List<int> ls1 = new List<int>();
            ls1 = mynums.FindAll(e => e > 13);
            foreach (var item in ls1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //mynums.Sort();    /* for doing sort values in the list we have to use sort */
            //mynums.Reverse();
            //foreach (int item in mynums)
            //{
            //    Console.WriteLine(item);

            //}
            ////Console.WriteLine("---------------------------");

            //Console.WriteLine($"{mynums.Count()} is count of given list") ;

            //Console.WriteLine("---------------------------");

            //mynums.Reverse();
            

            //foreach (int item in mynums)
            //{
            //    Console.WriteLine(item);

            //}
        }
        static void Main(string[] args)
        {
            listmethods();
            Console.ReadLine();
        }
    }
}
