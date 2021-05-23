/* Матущенко Наталья
3.
а) Написать программу, которая подсчитывает расстояние между точками 
с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/
using System;

namespace Task3
{
    class Program

    {
        static void Task_3a()
        {
            Console.WriteLine("Укажите координату x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату y2:");
            int y2 = int.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {r:F2}");
            Console.ReadKey();
        }

        static void Task_math(int x1, int x2, int y1, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {r:F2}");
        }

        static void Task_3b()
        {
            Console.WriteLine("Укажите координату x1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату y1:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату x2:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите координату y2:");
            int d = int.Parse(Console.ReadLine());
            Task_math(a, b, c, d);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Матущенко Наталья. Задача 3-а: Написать программу, которая подсчитывает расстояние между точками." +
                "Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой).");
            Task_3a();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья. Задача 3-b : Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.");
            Task_3b();
            Console.WriteLine(" ");
            Console.WriteLine("Конец 3 задачи.");
            Console.ReadKey();
        }
    }
}
