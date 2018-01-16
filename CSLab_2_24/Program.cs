using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задать последовательность целых чисел датчиком случайных чисел.  
 Найти номер максимального элемента в этой последовательности.*/

namespace CSLab_2_24
{
    class Program
    {
            static void Main(string[] args)
        {
            int i, Lenght, maxArr, Maxi;

            Console.Write("Введите длину последовательности: ");
            Lenght = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arr = new int[Lenght];          //создаем массив
            Random rnd = new Random();            //датчик случайных чисел

            for ( i = 0; i < arr.Length; i++)     //создаем массив с помощью датчика случайных чисел
            {
                arr[i] = rnd.Next(1, 100);        //датчик случайных чисел вносит в массив i-ый элемент от 1 до 100
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            maxArr = 0;                               //находим номер максимального элемента
            Maxi = 0;

            for (i = 0; i < arr.Length; i++)
            {
                    if (arr[i] > maxArr)
                { 
                        maxArr = arr[i];
                        Maxi = i;
                }
            }
            Console.WriteLine($"Номер максимального элемента {Maxi}");

            Console.ReadKey();
        }
    }
}
