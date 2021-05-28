/* Матущенко Наталья 
5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */
using System;

namespace Task5
{
    class Program
    {
        static void Task_5a()
        {
            Console.WriteLine("Матущенко Наталья.Москва");
        }
        static void Task_5b()
        {
            Console.SetCursorPosition(38 , 15);
            Console.WriteLine("Матущенко Наталья.Москва");
        }
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(38, 20);
            Console.WriteLine(ms);
        }
        static void Task_5c()
        {
            string ms = "Матущенко Наталья.Москва";
            int x = 50;
            int y = 25;
            Print(ms, x, y);

        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.WriteLine("Матущенко Наталья. Задача 5-а: Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.");
            Task_5a();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья. Задача 5-b : Сделать задание, только вывод организовать в центре экрана.");
            Task_5b();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья.  Задача 5-c : Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)");
            Task_5c();
            Console.WriteLine(" ");
            Console.WriteLine("Конец 5 задачи.");
            Console.ReadKey();
        }
    }
}
