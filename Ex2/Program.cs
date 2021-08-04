using System;

namespace Ex2 //// Студент Вечёрко Р.Д. 1) Написать метод подсчета количества цифр числа.
{
    class Program
    {
        private static int count;

        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число a:");
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                count++;

                a = a / 10;
                Console.WriteLine(count);







            }
        }
    }
}
