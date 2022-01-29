using System;
using System.IO;

namespace _8._3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/MyText.txt";
            int count_word = 0;            
            int count_line = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string path_text = sr.ReadToEnd();
                Console.WriteLine(sr.ReadToEnd());
                int length = path_text.Replace("\n", "").Replace("\r", "").Length;
                
                char[] separators = new char[] { ',', '.', '!', '?', ';', ':', ' ' };
                string[] string_array_1 = path_text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(path_text);

                foreach (string s in string_array_1)                    
                {
                    count_word += 1;
                }
                
                string[] string_array_2 = path_text.Replace("\n", "___").Replace("\r", "___").Split("______");
                foreach (string s in string_array_2)
                {
                    count_line += 1;
                }
                Console.WriteLine();
                Console.WriteLine("Количество символов в документе {0}", length);
                Console.WriteLine("Количество слов в документе {0}", count_word);
                Console.WriteLine("Количество строк в документе {0}", count_line);
            }
            Console.ReadKey();
        }
    }
}
