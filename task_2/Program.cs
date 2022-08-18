using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace task_2
{
    class Program
    {
        static string def_path = ConfigurationSettings.AppSettings["def_path"];
        
        public static void create_file()
        {
            //string def_path = ConfigurationSettings.AppSettings["PATH"];
            Console.WriteLine(def_path);
            using (FileStream stream = new FileStream(def_path+@"\sample.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                Console.WriteLine("file successfully created");
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("hello this is sample writing, hello this is demo");
                    Console.WriteLine("file written successfully");
                }
            }

        }
        public static void read_file()
        {
            
            using (FileStream stream = new FileStream(def_path+@"\sample.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine(data);
                }

            }


        }
        public static void append_data()
        {
            

            using (FileStream stream = new FileStream(def_path + @"\sample.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("This site can’t be reachedwww.google.com’s DNS address could not be found. Diagnosing the problem.");
                    Console.WriteLine("file successfully appended");
                }
            }

        }
        public static void display_info()
        {
            string path = ConfigurationSettings.AppSettings["PATH"];
            //using (FileStream stream = new FileStream(path + @"\sample.txt", FileMode.Open, FileAccess.Read))
            //{
            //    Console.WriteLine(stream.);
            //}
            var data = File.ReadLines(def_path + @"\sample.txt");
            Console.WriteLine(data.Count());


            var first_line = File.ReadLines(def_path + @"\sample.txt").First();
            foreach (var item in first_line)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            var last_line = File.ReadLines(def_path + @"\sample.txt").Last();
            foreach (var item2 in last_line)
            {
                Console.Write(item2);
            }
        }
        public static void copy_file()
        {
            File.Copy(def_path + @"\sample.txt", def_path+@"\sample_copied.txt");
            Console.WriteLine("file succesfully copied");
        }
        public static void del_file()
        {
            File.Delete(def_path+@"\sample.txt");
            Console.WriteLine("file successfully deleted");
        }
        public static void file_details(string path)
        {
            //string path = @"C:\Raviprasad\TASK_B\FILES\sample_copied.txt";

            Console.WriteLine("last access time is : " + File.GetLastAccessTime(path));
            Console.WriteLine("last modified time is :" + File.GetLastWriteTime(path));
            Console.WriteLine("file name is :" + Path.GetFileName(path));
            Console.WriteLine("file name without extention is : " + Path.GetFileNameWithoutExtension(path));

        }
        public static void move_files(string dest_path)
        {

            File.Move(def_path + @"\sample.txt", dest_path);
            Console.WriteLine("file moved successfully");
        }
        static void Main(string[] args)
        {
            //create_file();
            //read_file();
            //append_data();
            //display_info();
            //copy_file();
            //file_details(def_path + @"\sample.txt");
            move_files(def_path+@"\backup\sample.txt");
            Console.ReadLine();
        }
    }
}
