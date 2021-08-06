using System;

namespace Ex5 ////  Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
              ////  и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, I;
            
            Console.Write("Введите свой вес в (кг): ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("m = " + weight + " кг.");

            Console.Write("Введите свой рост в (м): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("h = " + height + " м.");

            I = weight / (height * height);
            Console.WriteLine("Ваш индекс массы тела (ИМТ) = " + I + " Кг/м2");


            if (I <= 18.4)
            {
                Console.WriteLine("У вас недостаточная масса тела");
            }
         
            if  (I <= 18.5 && I<=25)
            {
                Console.WriteLine("Ваш вес в пределах нормы");
            }

            if (I>=25.1)
            {
                Console.WriteLine("Вам нужно снизить вес");

            }
        }
    }
}
