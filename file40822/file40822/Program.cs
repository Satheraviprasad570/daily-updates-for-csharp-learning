using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace file40822
{
    class Program
    {
        public static void filecreation()
        {
            string path = @"C:\Raviprasad\filepractice4\sam.txt";
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                
                Console.WriteLine("file successfully created at given path");
                Console.ReadLine();

            }

        }
        public static void streamwriter()
        {
            string path = @"C:\Raviprasad\filepractice4\sam.txt";
            using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    Console.WriteLine("enter the string to save in file");
                    string data = Console.ReadLine();
                    writer.WriteLine(data);
                    Console.WriteLine("file successfully edited");

                }
            }
        }
        public static void streamreaderdemo()
        {
            string path = @"C:\Raviprasad\data\mydemo1.txt";
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Console.WriteLine("file opened successfully");
                using (StreamReader reader = new StreamReader(file))
                {
                    Console.WriteLine("file is ready to read...");
                    int line = reader.Peek();
                    Console.WriteLine(line);
                    
                    //if (reader.Peek()>0)
                    //{
                    //    Console.WriteLine("yes, file have contents ");

                    //}
                    //else
                    //{
                    //    Console.WriteLine("file dont have any content");
                    //}
                    //string consoleprinter = reader.ReadToEnd();
                    //char line = ' ';
                    //foreach(var item in reader.())
                    //{
                    //    Console.WriteLine(item);
                    //}

                    Console.ReadLine();


                }
                    

            }
        }

        static void Main(string[] args)
        {
            streamreaderdemo();
            Console.ReadLine();
        }
    }
}
