using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace directoryinfo
{
    class Program
    {
        public static void directorycreate()
        {
            string path = @"C:\Raviprasad";
       
            DirectoryInfo info = new DirectoryInfo(path);
            info.Create();
            Console.WriteLine("folder created successfully");
            Console.ReadLine();
        }
        public static void directorymove()
        {
            string path = @"C:\x directory";
            string path2 = @"C:\y directory";
            DirectoryInfo FS = new DirectoryInfo(path);
            FS.MoveTo(path2);
            Console.WriteLine("file successfully moved");
            Console.ReadLine();
        }
        public static void directoryfdelete()
        {
            string path = @"C:\y directory";
            DirectoryInfo file = new DirectoryInfo(path);
            file.Delete(true);
            Console.WriteLine($"file {path} deleted successfully");
            Console.ReadLine();
        }
        public static void getdirectories()
        {
            string path = @"C:\new";
            DirectoryInfo DS = new DirectoryInfo(path);
            DirectoryInfo [] data = DS.GetDirectories();
            foreach (var i in data)
            {
                Console.WriteLine(i.FullName);
            }
            //Console.WriteLine(data);
            Console.ReadLine();
        }
        public static void grabfiles()
        {
            string path = @"C:\new";
            DirectoryInfo files = new DirectoryInfo(path);
            DirectoryInfo[] path2 = files.GetDirectories();
            Console.WriteLine(files.Name);
            Console.WriteLine(files.FullName);
            Console.WriteLine(files.LastAccessTime);
            Console.WriteLine(files.Attributes);
            Console.WriteLine(files.Parent);
            Console.WriteLine(files.Root);
            Console.WriteLine(files.LastWriteTime);
            Console.WriteLine(files.LastWriteTimeUtc);
            Console.ReadLine();
            
        }
        public static void textwriter()
        {
            string path = @"C:\new\new1\text.txt";
            using (TextWriter wr = File.CreateText(path))
            {
                wr.WriteLine("hello this is also sample text");
             
            }
            Console.WriteLine("file written successfully");
        }
        public static void textwriter2()
        {
            string path = @"C:\new\new1\test2.txt";
            using (TextWriter wr2 = File.CreateText(path))
            {
                for (int i = 0; i < 100; i++)
                {
                    wr2.WriteLine((i+1)+" hello this statement is printed by for loop");
                }

            }
            Console.WriteLine("file is written successfully");
            Console.ReadLine();
        }
        public static void textreader()
        {
            string path = @"C:\new\new1\test2.txt";
            using (TextReader rd = File.OpenText(path))
            {
                Console.WriteLine(rd.ReadToEnd());
            }
        }
        static void Main(string[] args)
        {
            textreader();
            
            Console.ReadLine();
        }
    }
}
