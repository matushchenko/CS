/* Матущенко Наталья
4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/

using System;

namespace Task4
{
    class Program
    {
        // с использованием третьей переменной;
        static void Task_4a()
        {
            
            Console.WriteLine("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Первоначальные значения: " + " a = " + a + " b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Итоговые значения: " + " a = " + a + " b = " + b);
        }


        //б) *без использования третьей переменной;
        static void Task_4b()
         {
            
            Console.WriteLine("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Первоначальные значения: " + " a = " + a + " b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Итоговые значения: " + " a = " + a + " b = " + b);
         }

        static void Main()
        {
            Console.WriteLine("Матущенко Наталья. Задача 4-а: обмена значениями двух переменных с использованием третьей переменной");
            Task_4a();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья. Задача 4-b : обмена значениями двух переменных без использования третьей переменной");
            Task_4b();
            Console.WriteLine(" ");
            Console.WriteLine("Конец 4 задачи.");
            Console.ReadKey();


        }
                
        }



    }

