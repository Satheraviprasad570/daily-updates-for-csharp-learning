using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace filepractice
{
    class Program
    {


        public static void Copyfile() //have to require paths to copy files
        {
            string path1 = @"C:\Raviprasad\data\sample.txt";
            string path2 = @"C:\Raviprasad\data\sample3.txt";
            File.Copy(path1, path2);
            Console.WriteLine(" file successfully copied");
        }
        public static void Movefile() 
        {
            string path1 = @"C:\Raviprasad\data\sample.txt";
            string path2 = @"C:\Raviprasad\data\sample4.txt";

            File.Move(path1, path2);
            Console.WriteLine("file moved.");

        }
        public static void Isexist()
        {
            string path = @"C:\Raviprasad\data\sample4.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("entered file is present.");

            }
            else
            {
                Console.WriteLine("entered file is not present");
            }
        }
        public static void Delete()
        {
            string path = @"C:\Raviprasad\data\sample4.txt";

            File.Delete(path);
            Console.WriteLine("file deleted");
        }
        public static void Creationtime()
        {
            string Path = @"C:\Raviprasad\data\demo.pdf";
            DateTime dt = File.GetCreationTime(Path);
            Console.WriteLine($"created time is : {dt}");
        }
        public static void Lastwritetime()
        {
            string path = @"C:\Raviprasad\data\demo.pdf";
            DateTime dt = File.GetLastWriteTime(path);
            Console.WriteLine($" last edited time : {dt}");
        }
        public static void Createfile()
        {
            string path1;
            Console.WriteLine("enter file name with its extention to create it : ");
            path1 = Console.ReadLine();
            string path = $@"C:\Raviprasad\data\{path1}";
            FileStream sample = new FileStream(path, FileMode.Create);
            Console.WriteLine(@"file successfully created in C\Raviprasad\data");
        }
        public static void Streamwriter()
        {
            string data;
            Console.WriteLine("write text below to save it in given file");
            data = Console.ReadLine();
            string path = @"C:\Raviprasad\data\mydemo1.txt";
            using(FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                Console.WriteLine("file created and opened for write");
                using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                {
                    writer.WriteLine(data);

                    
                }
                Console.WriteLine("file written and successfully closed");
            }   
        }
        public static void Streamreader()
        {
            string path = @"E:\Work\WinAutomation\Watin Codes\sampleCodes\Fiddler\Seamanger_RFQ_PO_HTTP_Processor\bin\Debug\Log\Log_20171128.txt";
            using(FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader= new StreamReader(file))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine(data);

                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //string path = @"C:\Raviprasad\data\sample.txt";
            //using(FileStream sample = new FileStream(path, FileMode.Create,FileAccess.Write,FileShare.Read))
            //{
            //    string data ="so here ae are entering data in the firm";
            //    byte[] fs = Encoding.UTF8.GetBytes(data);
            //    sample.Write(fs, 0, data.Length);
            //    Console.WriteLine(" your file is ready go and check");



            //}

            //string varpath= @"C:\Raviprasad\data\sample.txt";
            //string patvar = @"C:\Raviprasad\data\sample2.txt";
            //File.Copy(varpath, patvar);
            Streamreader();
            Console.ReadLine();
        }
    }
}
