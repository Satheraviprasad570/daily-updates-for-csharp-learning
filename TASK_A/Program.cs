using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;




namespace TASK_A
{
     class Program
    {
        
        
        public static void file_create()
        {
            //string pathVal = ConfigurationManager.AppSettings["PATH"];
            string path = @"C:\Raviprasad\TASK_A\files\employees.txt";
            string path2 = @"C:\Raviprasad\TASK_A\files\employees.json"; 
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                Console.WriteLine("txt file is created successfully");
                Console.ReadLine();
            }
            using (FileStream file2 = new FileStream(path2, FileMode.Create, FileAccess.ReadWrite))
            {
                Console.WriteLine("json file is created successfully");
                Console.ReadLine();
            }
            
        }
        public static void write_data()
        {
            //string pathVal = ConfigurationManager.AppSettings["PATH"];
            string path = @"C:\Raviprasad\TASK_A\files\employees.txt";
            string path2 = @"C:\Raviprasad\TASK_A\files\employees.json";
            Employee[] data = {new Employee(){Name="rahul chauhan",Age=24,Salary= 20000,Desgination="Software developer"},
                                new Employee(){Name="Sanjay rathod",Age=25,Salary=20000,Desgination="software developer"},
                                new Employee(){Name="shankaran pilai",Age=39,Salary= 60000,Desgination="managing director"}                             
                             };
            var final_data = JsonConvert.SerializeObject(data);
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(final_data);
                    Console.WriteLine(".txt file written successfully");

                }
            }
            using (FileStream stream2 = new FileStream(path2, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamWriter writer2 = new StreamWriter(stream2, Encoding.UTF8))
                {
                    writer2.WriteLine(final_data);
                    Console.WriteLine(".json file is written successfully");
                }
            }
            //Employee[] additional_data = {
            //                                 new Employee(){Name="sudhir phadake",Age=43,Salary=30000,Desgination="singer"},
            //                                 new Employee(){Name = "sachin tendulkar",Age =55,Salary=100000,Desgination="cricketer"}
            //                             };
            //var final_data2 = JsonConvert.SerializeObject(additional_data);


            
        }
        public static void appenddata()
        {
            string path = @"C:\Raviprasad\TASK_A\files\employees.txt";
            string path2 = @"C:\Raviprasad\TASK_A\files\employees.json";
            Employee[] additional_data = {
                                             new Employee(){Name="sudhir phadake",Age=43,Salary=30000,Desgination="singer"},
                                             new Employee(){Name = "sachin tendulkar",Age =55,Salary=100000,Desgination="cricketer"}
                                         };
            var final_data = JsonConvert.SerializeObject(additional_data);
            using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(final_data);
                    Console.WriteLine("data appended to txt file successfully");
                }
            }
            using (FileStream stream2 = new FileStream(path2, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer2 = new StreamWriter(stream2))
                {
                    writer2.WriteLine(final_data);
                    Console.WriteLine("data appended to json file successfully");
                }
            }
        }

        public static void textread()
        {
            string path = @"C:\Raviprasad\TASK_A\files\employees.txt";
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    // string data = reader.ReadToEnd();
                    foreach (var item in reader.ReadToEnd())
                    {
                        Console.Write(item);
                    }
               
                }
            }
        }
        public static void jsonread()
        {
            string path =  @"C:\Raviprasad\TASK_A\files\employees.json";
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string data = reader.ReadToEnd();
                    var query = (from x in data select x) ;
                    Console.WriteLine(query.Count());
                    foreach (var item in query)
                    {
                        Console.Write(item );
                    }
                }
            }
        }
        public static void file_details()
        {//[access time , modified time,filename
            string path = @"C:\Raviprasad\TASK_A\files\employees.txt";
            string path2 = @"C:\Raviprasad\TASK_A\files\employees.json";
            Console.WriteLine("text file directory is :"+ Path.GetDirectoryName(path));
            FileInfo file = new FileInfo(path);
            Console.WriteLine("text file last write time is :"+file.LastWriteTime);
            Console.WriteLine( "file name is :"+file.Name);
            Console.WriteLine("--------------------------");
            FileInfo file2 = new FileInfo(path2);

            Console.WriteLine("json file directory is :" + Path.GetDirectoryName(path2));
            Console.WriteLine("json file last write time is :"+file2.LastWriteTime);
            Console.WriteLine("file name is :"+file2.Name);
             
        }
       static void Main(string[] args)
        {
            //write_data();
            //file_create();
            //textread();
            jsonread();
            //appenddata();
            //file_details();
            Console.ReadLine();
        }
    }
}
