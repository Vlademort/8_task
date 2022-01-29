using System;
using System.IO;

namespace _8._2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Logs.txt";
            int S = 0;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                int[] array = new int[10];
                Random random = new Random();                
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 50);
                    sw.Write("{0} ", array[i]);
                }                
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string[] string_array = sr.ReadToEnd().Split(' ');
                foreach (string sa in string_array)                    
                {
                    string s = sa.Trim();
                    if (s == "")
                    {
                        break;
                    }    
                    int n = Convert.ToInt32(s);
                    S += n;                    
                }                

                Console.WriteLine("Сумма чисел в тестовом документе равна {0}", S);                
            }
            Console.ReadKey();
        }
    }
}
