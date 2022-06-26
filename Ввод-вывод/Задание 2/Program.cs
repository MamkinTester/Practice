using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static string path = @"C:\Users\user\source\repos\Ввод-вывод\задание2.txt";
        static void Main(string[] args)
        {
            using (FileStream fs = File.Create(path)) { }
                using (StreamWriter sw = new StreamWriter(path))
                {
                        sw.WriteLine("текст");
                }

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
