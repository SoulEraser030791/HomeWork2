using System;

namespace Ex5 ////  Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
              ////  и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
              ///б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, I, In;
            
            Console.Write("Введите свой вес в (кг): ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("m = " + weight + " кг.");

            Console.Write("Введите свой рост в (м): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("h = " + height + " м.");

            I = weight / (height * height);
            Console.WriteLine("Ваш индекс массы тела (ИМТ) = " + I + " Кг/м2");


            if (I <= 18.49)
            {
                In = (18.49 - I) * height * height;
                Console.WriteLine("У вас недостаточная масса тела, для нормализации веса нужно набрать: " + In + " Кг");
            }
                       
            if  (I >= 18.5 && I<=24.99)
            {
                Console.WriteLine("Ваш вес в пределах нормы");
            }

            if (I>=25)
            {
                In = (I - 24.99) * height * height;
                Console.WriteLine("У вас избыточный вес, для его нормализации  нужно сбросить: " + In + " Кг");
            }
        }
    }
}
