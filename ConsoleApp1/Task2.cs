using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            int a = Convert.ToInt32(Console.ReadLine());
            int s, v;
            SqVolQa(a, out s, out v);
            Console.WriteLine("Площадь {0}, объем {1}", s, v);
            Console.ReadKey();
        }
        static void SqVolQa(int a, out int s, out int v)
        {
            s = a * a * 6;
            v = a * a * a;
        }

    }
}
