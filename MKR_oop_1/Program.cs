using System;

namespace MKR_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, -2, 3, 1, 1, 1, 4, -5, 6, 7, 8, -9, -9, 11, 3, -12, 0, 0, 14, 14, 14, 14, 14, 6, 4, 8, 0 };
            for (int i = 0; i < mass.Length - 1; i++)
            {
                int num = mass[i];
                if (num == mass[i + 1])
                {
                    Console.Write($"{num}");
                    int count = 1;
                    while (i < (mass.Length - 1) && mass[i + 1] == num) { count++; i++; }
                }
    }
}
