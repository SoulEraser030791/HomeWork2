using System;

namespace Ex3 //// Студент Вечёрко Р.Д. С клавиатуры вводятся числа, пока не будет введен 0.
              //// Подсчитать сумму всех нечетных положительных чисел.
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            uint oddNumbers = 0;
            do 
        {
            Console.WriteLine("Введите целое положительное число A");
            A = int.Parse(Console.ReadLine());
                int n = A % 2;
                
                if (n == 0)
                {
                    Console.WriteLine("Число является четным");
                }
                else 
                {
                    oddNumbers++;
                    Console.WriteLine("Число является нечетным");
                }
                             
                                
        }
            
       while (A > 0) ;
            Console.WriteLine("Количество введенных нечетных положительных чисел= " + oddNumbers);

            
        }
        }
    }
