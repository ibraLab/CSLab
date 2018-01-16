using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 СДЕЛАНО
 1)	Сформировать массив из n элементов с помощью датчика случайных чисел(n задается пользователем с клавиатуры).
2)	Распечатать массив.
3)  Выполнить удаление четных элементов из массива.
4)  Выполнить добавление указанных элементов в массив (К-элементов в начало массива).

НЕ СДЕЛАНО
5)  Выполнить перестановку элементов в массиве.
6)	Выполнить поиск указанных в массиве элементов и подсчитать количество сравнений, 
необходимых для поиска нужного элемента.
7)  Выполнить сортировку массива указанным методом.
8)	Выполнить поиск указанных элементов в отсортированном массиве и подсчитать количество сравнений, 
необходимых для поиска нужного элемента.*/

namespace CSLab_4_5
{
    class Program
    {
        static int ReadInNumber(string msg)
        {
            Console.Write(msg);
            bool ok;
            int number;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out number);
                if (!ok)
                    Console.WriteLine("Введите значение корректно");
            }
            while (!ok);
            return number;
        }

        static int[] MakeRandom(int size)
        {
            int[] Arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                Arr[i] = rnd.Next(0, 100);
            return Arr;
        }

        static void PrintArr(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
                Console.Write(Arr[i] + "   ");
            Console.WriteLine();
        }

        static int CountEvenElement(int[] Arr, int size1)                       //Подсчет количества четных элементов в массиве
        {
            int i, k = 0;
            for (i = 0; i < Arr.Length; i++)
                if (Arr[i] % 2 == 0)
                    k += 1;
            size1 = Arr.Length - k;
            return size1;                                                 //длина массива без четных элементов
        }

        static int[] DellCountEvenElement(int[] Arr, int size1)          //Удаление четных элементов из массива
        {
            int i, j;
            int[] Arr1 = new int[size1];                                //Создание массива Arr1
            j = 0;
            for (i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 != 0)
                {
                    Arr1[j] = Arr[i];
                    j++;
                }
            }
            foreach (int x in Arr1) Console.Write(x + " ");                 //печать массива на экран
            return Arr1;
        }

        static int[] AddArr(int[] Arr, int k, int size)
        {
            int size3;

            size3 = k;                                           //формирование массива, добавляемых элементов
            int[] Arr3 = new int[size3];
            Random rnd = new Random();
            for (k = 0; k < size3; k++)
                Arr3[k] = rnd.Next(0, 100);
            foreach (int x in Arr3) Console.Write(x + " ");                 //печать массива на экран
            return Arr3;
        }

        static int[] AddElementArr(int[] Arr, int[]Arr3, int k, int size, int size3)
        {
            int i, j, size2;
            size2 = size + size3;
            j = size - 1;
            k = size3-1;
            int[] Arr2 = new int[size2];
            for (i = size2 - 1; i >= 0; i--)             //формирование массива Arr2 из элементов Arr3 и Arr
                if (j >= 0)
                {
                    Arr2[i] = Arr[j];
                    j--;
                }
                else
                    if (k >= 0)
                {
                    Arr2[i] = Arr3[k];
                    --k;
                } 
            foreach (int x in Arr2) Console.Write(x + " ");                 //печать массива на экран
            return Arr2;
        }







        static void Main(string[] args)
        {
            int size, size1 = 0, size2 = 0, size3=0, k;
            size = ReadInNumber("Введите количество элементов в массиве: ");
            int[] Arr = new int[size];
            Arr = MakeRandom(size);
            PrintArr(Arr);
            size1 = CountEvenElement(Arr, size1);                                   //определение длины массива без четных элментов
            Console.WriteLine($"Длина массива Arr1: {size1}");
            int[] Arr1 = new int[size1];                                          //создание пустого массива Arr1 
            Console.Write("Массив без четных элементов: ");
            Arr1 = DellCountEvenElement(Arr, size1);
            Console.WriteLine();
            int[] Arr2 = new int[size2];                                              
            k = ReadInNumber("Введите количество добавляемых элементов в массив Arr: ");           //количество добавляемых элементов в массив
            Console.WriteLine();
            Console.Write("Добавляемые справа в массив элементы: ");
            int[]Arr3 = new int[size3];
            Arr3 = AddArr(Arr, k, size);                                             //добавляемый массив элементов
            Console.WriteLine();
            Console.Write ("Массив после сдвига на {0} элементов вправо: ", k);
            Arr2 = AddElementArr(Arr, Arr3, k, size, size1);

            Console.ReadKey();
        }
    }
}



        
    

    

