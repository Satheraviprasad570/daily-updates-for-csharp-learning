using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftcollections
{
    class Program                           //sorted list accepts the key and value pairs  
    {
        public static void sortedls()
        {//this is sample of creating sorted list
            SortedList<string, string> mysortedls = new SortedList<string, string>();
            mysortedls.Add("hello", "hello welcome to amira consultant");
            mysortedls.Add("how", "hey how are you, how  was your day");
           
        }
        public static void sortedlsfetch()
        {  //this is fetching sorted list by using loop
            SortedList<int, string> sortedls1 = new SortedList<int, string>();
            sortedls1.Add(1, "raviprasad sathe");
            sortedls1.Add(2, "mauli jadhav");
            sortedls1.Add(3, "amira consultant");

            foreach (var item in sortedls1)
            {
                Console.WriteLine(item);
            }
        }
        public static void sortedlsfetch2()
        {
            SortedList<int, string> sortedls2 = new SortedList<int, string>();
            sortedls2.Add(1, "mauli jadhav");
            sortedls2.Add(2, "raviprasad sathe");
            sortedls2.Add(3, "amira consultant");

            HashSet<int> mydata = new HashSet<int>();
            mydata.Add(10);
            mydata.Add(10);
            mydata.Add(10);
            mydata.Add(20);
            mydata.Add(30);
            mydata.Add(40);


          
            Console.WriteLine(mydata.Count);
            foreach (var item in mydata)
            {
                Console.WriteLine(item);
            }
        }
        public static void mystack()
        {
            Stack mystack = new Stack();

            mystack.Push("hello");
            mystack.Push(1010);
            mystack.Push("end of the stack");
            mystack.Push("this is start of the stack but will now display");
            mystack.Push(101);
            mystack.Pop();
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }



        }
        public static void myqueue()
        {
            Queue demoqueue = new Queue();
            demoqueue.Enqueue("hello there this is first string");
            demoqueue.Enqueue(101);
            demoqueue.Enqueue("this is last string entered");

            demoqueue.Dequeue();

            foreach (var item in demoqueue)
            {
                Console.WriteLine(item);
            }
        }
        public static void myhashset()
        {
            HashSet<int> sample = new HashSet<int>();
            sample.Add(10);
            sample.Add(11);
            sample.Add(12);
            sample.Add(13);
            sample.Add(13);

            Console.WriteLine(sample.Count());

            foreach (var item in sample)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            myhashset();
            Console.ReadLine();
        }
    }
}
