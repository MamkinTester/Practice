using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        class Converter
        {
            private double _rub;
            private double _usd;
            private double _eur;
            
            public Converter(double usd, double eur, double rub)
            {
                _rub = rub;
                _usd = eur;
                _eur = eur;
            }
            public Converter()
            {

            }


            public double ConvertToGrivna(int val)
            {
                switch (val)
                {
                    case 1:
                        Console.WriteLine("Введите уоличество рублей");
                        _rub = Convert.ToDouble(Console.ReadLine());
                        return _rub * 0.52;
                    case 2:
                        Console.WriteLine("Введите уоличество долларов");
                        _usd = Convert.ToDouble(Console.ReadLine());
                        return _usd * 29.54;
                    case 3:
                        Console.WriteLine("Введите уоличество евро");
                        _eur = Convert.ToDouble(Console.ReadLine());
                        return _eur * 30.83;
                    default:
                        return 0;
                }
            }

            public double ConvertFromGrivna(double grivna, int val)
            {
                switch (val)
                {
                    case 1:
                        return grivna * 1.92;
                    case 2:
                        return grivna * 0.034;
                    case 3:
                        return grivna * 0.032;
                    default:
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Converter conv = new Converter();
            Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
            string res = Console.ReadLine();
            while (res == "1" || res == "2")
            {
                if(res == "1")
                {
                    Console.WriteLine("Введите количество гривен");
                    double gr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("В какую валюту хотите перевести? \n1 - в рубли\n2 - в доллары\n3 - в евро");
                    Console.WriteLine(conv.ConvertFromGrivna(gr, Convert.ToInt32(Console.ReadLine())));
                }
                if (res == "2")
                {
                    Console.WriteLine("Какую валюту хотите перевести в гривны? \n1 - рубли\n2 - доллары\n3 - евро");
                    Console.WriteLine(conv.ConvertToGrivna(Convert.ToInt32(Console.ReadLine())));
                }
                Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
                res = Console.ReadLine();
            }
        }
    }
}
