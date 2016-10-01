using System;

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
			Console.WriteLine("Write a hw number");
			int DZ = Convert.ToInt32(Console.ReadLine());

			switch (DZ)
			{
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
