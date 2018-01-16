using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*16.	Дана последовательность из n целых чисел. 
 Найти количество элементов этой последовательности, кратных числу K1  и не кратных числу K2*/

namespace CSLab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int el, num, i, sum=0,k1,k2;

            Console.Write("Ввести количество элементов последовательности: ");   //el-количество элементов последовательности
            el = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввести число k1: ");
            k1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввести число k2: ");
            k2 = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            for (i = 0; i < el; i++)
            {
                    num = rnd.Next(0, 100);
                    Console.Write(num + "\t");
                {
                    if ((num % k1 == 0) && (num % k2 != 0))
                        sum += 1;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Количество элементов в последовательности кратных {0} и не кратных {1} = {2}", k1,k2,sum);

            Console.ReadKey();
            
        }
    }
}
