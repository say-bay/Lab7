using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину a первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину b первого треугольника");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину c первого треугольника");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину a второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину b второго треугольника");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину c второго треугольника");
            int c2 = Convert.ToInt32(Console.ReadLine());
            if (SqTr(a1, b1, c1) > SqTr(a2, b2, c2))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (SqTr(a1, b1, c1) < SqTr(a2, b2, c2))
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            Console.ReadKey();
        }
        static double SqTr(int i1, int i2, int i3)
        {
            int p = i1 + i2 + i3;
            double S = Math.Sqrt(p * (p - i1) * (p - i2) * (p - i3));
            return S;
        }

    }
}
