using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*записать выражение, зависящее от координат точки X1 и Y1 и принимающее значение TRUE,
  если точка принадлежит заштрихованной области, и FALSE, если не принадлежит.*/

namespace CSLab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool result=false;

            Console.Write("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if ((x > 0 && x < 5) && (y > 0 && y < 5))
                result = true;
                Console.WriteLine($"{result}");
            Console.ReadKey();


        }
    }
}
