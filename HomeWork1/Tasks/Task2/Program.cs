/* Матущенко Наталья
2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 */
using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Матущенко Наталья. Задача 2: Рассчитать и вывести индекс массы тела");
            Console.WriteLine("Укажите ваш вес в кг.");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш рост в см.");
            double h = double.Parse(Console.ReadLine())/100;
            double ii = m/(h*h);
            int i = Convert.ToInt32(ii);
            Console.WriteLine("Индекс массы тела: = " + i  );
            Console.WriteLine(" ");
            Console.WriteLine("Конец 2 задачи.");
            Console.ReadKey();
        }
    }
}
