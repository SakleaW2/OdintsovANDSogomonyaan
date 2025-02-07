using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace App_18
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Заполнить массив из 10 элементов случайными числами от 0 до 10 Подсчитать и вывести сколько" +
                "\r\nраз в данном массиве встречается каждое число.");
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(11);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            int[] number = new int [11];
            for (int i = 0; i < array.Length; i++) {
                number[array[i]]++;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    Console.WriteLine($"Число {i} встречается {number[i]} раз.");
                }
            }
        }
    }
}