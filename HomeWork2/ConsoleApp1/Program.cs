﻿using System;

namespace ConsoleApp1
{
    class Program
    {
		static void Main(string[] args)
		{
			int a, count = 0;
			do
			{
				Console.Write("Введите возраст:");
				a = int.Parse(Console.ReadLine());
				count++;
			}
			while (a < 1 || a > 99);// Повторять пока условие истинно(true)
			Console.WriteLine("Вы сделали " + count + " попыток ввода");
		}

	}
}
