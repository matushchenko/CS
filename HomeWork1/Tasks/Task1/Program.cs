/*Матущенко Наталья
1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку:
а) используя склеивание
б) используя форматированный вывод
в) используя вывод со знаком $
*/
using System;

namespace Task1_a
{
    class Program_a
    {
        // а) используя склеивание
        static void Task_1a()
        {
            Console.WriteLine("Укажите ваше имя.");
            string a = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию.");
            string b = Console.ReadLine();
            Console.WriteLine("Укажите ваш возраст.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваше рост.");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес.");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " " + b + " " + c + " лет/года " + d + " см " + i + " кг");
            Console.ReadKey();
        }
            // б) используя форматированный вывод
        static void Task_1b()
        {
            Console.WriteLine("Укажите ваше имя.");
            string a = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию.");
            string b = Console.ReadLine();
            Console.WriteLine("Укажите ваш возраст.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваше рост.");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес.");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} лет/года {3} см {4} кг", a,b,c,d,i);
            Console.ReadKey();

        }
        //в) используя вывод со знаком $
        static void Task_1c()
        {
            Console.WriteLine("Укажите ваше имя.");
            string a = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию.");
            string b = Console.ReadLine();
            Console.WriteLine("Укажите ваш возраст.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваше рост."); 
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес.");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} {b} {c} лет/года {d} см {i} кг") ;
            Console.ReadKey();
        }
        static void Main()
        {
            Console.WriteLine("Матущенко Наталья. Задача 1-а: Написать программу «Анкета», используя склеивание.");
            Task_1a();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья. Задача 1-б :  Написать программу «Анкета», используя форматированный вывод.");
            Task_1b();
            Console.WriteLine(" ");
            Console.WriteLine("Матущенко Наталья. Задача 1-в :  Написать программу «Анкета», используя вывод со знаком $.");
            Task_1c();
            Console.WriteLine(" ");
            Console.WriteLine("Конец 1 задачи.");
            Console.ReadKey();


        }

    }
  }


