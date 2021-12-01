using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program     // метод нахождения и сравнения площадей двух треугольников
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону Х первого треугольника");                       // ввод данных
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Y первого треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Z первого треугольника");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите сторону Х второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Y второго треугольника");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Z второго треугольника");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double S1;
            double S2;

            if (x1 > y1 + z1 || y1 > x1 + z1 || z1 > x1 + y1)                                     //проверка на существование треугольника №1
            {
                Console.WriteLine("Неверно введены данные! Треугольник №1 не существует!");
            }
            else
            {
                S1 = GetParam(x1, y1, z1);
            }

            if (x2 > y2 + z2 || y2 > x2 + z2 || z2 > x2 + y2)                                     //проверка на существование треугольника №2
            {
                Console.WriteLine("Неверно введены данные! Треугольник №2 не существует!");
            }
            else
            {
                S2 = GetParam(x2, y2, z2);
            }

            S1 = GetParam(x1, y1, z1);
            S2 = GetParam(x2, y2, z2);

            if (S1 == S2)                                                                             // сравнение площадей треугольников
            {
                Console.WriteLine("Площади треугольников №1 и №2 равны:\nS1= S2= {0:0.00}", S1);
            }

            if (S1 > S2)                                                                               // сравнение площадей треугольников
            {
                Console.WriteLine("Площадь треугольника №1 больше:\n S1= {0:0.00}\n S2= {1:0.00}", S1, S2);
            }

            if (S2 > S1)                                                                                 // сравнение площадей треугольников
            {
                Console.WriteLine("Площадь треугольника №2 больше:\n S1= {0:0.00}\n S2= {1:0.00}", S1, S2);
            }


            Console.ReadKey();
        }

        static double GetParam(double x, double y, double z)   // метод нахождения площади треугольника           
        {

            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }

       

    }
}
