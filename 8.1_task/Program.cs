using System;
using System.IO;

namespace _8._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\AU 2020 тест";
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] diArr = directory.GetDirectories();

            if (!directory.Exists)
            {                
                Console.WriteLine("Такой папки по указанному пути не существует.");
            }
            else
            {
                Console.WriteLine("Папка AU 2020 тест");
                foreach (string info in Directory.GetFiles(path))
                {
                    Console.WriteLine(" {0}",info);                    
                }
                Console.WriteLine();

                foreach (DirectoryInfo dri in diArr)
                {
                    Console.WriteLine("   Папка AU 2020 тест\\{0}", dri.Name);
                    foreach (var info in dri.GetFiles())
                    {
                        Console.WriteLine("       {0}",info);                        
                    }
                    Console.WriteLine();

                }
                   


            }
                      

                       
            Console.ReadKey();
        }
    }
}
