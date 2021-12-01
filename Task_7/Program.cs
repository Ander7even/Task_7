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
            Console.WriteLine("Введите сторону Х первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Y первого треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Z первого треугольника");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону Х второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Y второго треугольника");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону Z второго треугольника");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double p1, S1;
            double p2, S2;

            if (x1 > y1 + z1 || y1 > x1 + z1 || z1 > x1 + y1)
            {
                Console.WriteLine("Неверно введены данные! Треугольник №1 не существует!");
            }
            else
            {
                GetParam1(x1, y1, z1, out p1, out S1);
            }

            if (x2 > y2 + z2 || y2 > x2 + z2 || z2 > x2 + y2)
            {
                Console.WriteLine("Неверно введены данные! Треугольник №2 не существует!");
            }
            else
            {
                GetParam2(x2, y2, z2, out p2, out S2);
            }


            GetParam1(x1, y1, z1, out p1, out S1);
            GetParam2(x2, y2, z2, out p2, out S2);

            if (S1==S2)
            {
                Console.WriteLine("Площади треугольников №1 и №2 равны S1= S2= {0:0.00}", S1);
            }

            if (S1>S2)
            {
                Console.WriteLine("Площадь треугольника №1 больше:\n S1= {0:0.00}\n S2= {1:0.00}", S1,S2);
            }

            if (S2>S1)
            {
                Console.WriteLine("Площадь треугольника №2 больше:\n S1= {0:0.00}\n S2= {1:0.00}", S1, S2);
            }

            
            Console.ReadKey();
        }

        static void GetParam1(double x1, double y1, double z1, out double p1, out double S1)
        {

            
            p1 = (x1 + y1 + z1) / 2;
            S1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));

        }

        static void GetParam2(double x2, double y2, double z2, out double p2, out double S2)
        {

            p2 = (x2 + y2 + z2) / 2;
            S2 = Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));
        }











    }
}
