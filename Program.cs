﻿using System;

namespace HWProg
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Краткая инструкция" +
			                  "\n1. Надо ввести номер задания" +
			                  "\n2. Надо ввести требуемые переменные" +
			                  "\n ");
			Console.WriteLine("Write a hw number (1,3,4)");
			int DZ = Convert.ToInt32(Console.ReadLine());

			switch (DZ)
			{
				case 1:
					Num1();
					break; 
					
				case 3:
					Num3();
					break;

				case 4:
					Num4();
					break;

				default:
					break;
			}
		}

		public static void Num1()
		{
			Console.WriteLine("Введите целое число:");

			int number = Convert.ToInt32(Console.ReadLine());
			int result;

			if (number > 0)
			{
				result = number * 2;
			}
			else if (number < 0)
			{
				result = number - 3;
			}
			else
			{
				result = 10;
			}

			Console.WriteLine(result);
		}

		public static void Num3()
		{
			Console.WriteLine("Write number");
			int num = Convert.ToInt32(Console.ReadLine());
			int addnum = num;
			Console.WriteLine("Write additional number");
			int n = Convert.ToInt32(Console.ReadLine());
			if (n > 0)
			{
				for (int i = 2; i <= n; i++)
				{
					num = num * addnum;
				}
				Console.WriteLine("Result is " + num);
			}
			else {
				Console.WriteLine("Wrong additional number");
			}
		}

		public static void Num4()
		{
			Console.WriteLine("x^2=y");
			Console.WriteLine("y=?");
			double y = Convert.ToDouble(Console.ReadLine());
			if (y > 0)
			{
				double x = Math.Sqrt(y);
				Console.WriteLine("x=" + x);
			}
			else
			{
				Console.WriteLine("Wrong y");
			}

		}
	}
}
