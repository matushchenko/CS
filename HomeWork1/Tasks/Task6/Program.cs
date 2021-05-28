/* Матущенко Наталья
 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
*/
using System;

namespace Task6
{
    class Program
    {
         static void Pause()
        {
            Console.ReadKey();
        }

        static void Print(int x)
        {
            Console.WriteLine(x);
        }

        static void Main()
        {
            int x = 1;
            Print(x);
            Pause();
        }

    }
}
