using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args) //метод нахождения площади граней и объема куба по длине его ребра
        {
            Console.WriteLine("Введите длину ребра куба");                      
            double a = Convert.ToDouble(Console.ReadLine());
            double S, V;


            if (a <= 0)
            {
                Console.WriteLine("Неверно введены данные!");
            }

            S = GetParam1(a);
            V = GetParam2(a);
            Console.WriteLine("Площадь куба равна S= {0:0.00}", S);
            Console.WriteLine("Объем куба равен V= {0:0.00}", V);

            Console.ReadKey();
        }

        static double GetParam1(double a)
        {
            double S = 6 * Math.Pow(a, 2);
            return S;
        }
        static double GetParam2(double a)
        {

            double V = Math.Pow(a, 3);
            return V;
        }


    }
}
