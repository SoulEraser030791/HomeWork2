using System;

namespace HomeWork2 ///Студент Вечёрко Р.Д. 1) Написать метод, возвращающий минимальное из трёх чисел.
{
    class Program
    {
        static void Main(string [] args)
        {

            int a,b,c,min;
            Console.Write("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c:");  
            c = Convert.ToInt32(Console.ReadLine());
            min = Math.Min(Math.Min(a, b), Math.Min(b, c));
            

            Console.WriteLine("Наименьшее из чисел:" + min);
            Console.ReadLine();
        }
    }
}
