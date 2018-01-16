using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*24.	Дана последовательность целых чисел, за которой следует 0. 
 * Найти номер максимального элемента в этой последовательности.*/

namespace CSLab_2_24_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;             //элемент последовательности
            int i = 1;        // счетчик итераций
            int index=0;     //индекс максимального элемента
            int max;          // значение максимального элемента

            max = int.MinValue;

            do                                                           //ввод последовательности, оканчивающейся 0
            {
                Console.Write("Введите элемент последовательности: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x > max)
                {
                    index = i;
                    max = x;
                }
                i++;
            }
            while (x != 0);

            Console.WriteLine("Максимальный элемент={0}, номер максимального элемента={1}", max, index);
            Console.ReadKey();
        }
    }
}
