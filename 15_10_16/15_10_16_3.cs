using System;

namespace HW15_10_16
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] mas = new int[10];
			int polNum = 0;
			double srZnach = 0;

			Console.WriteLine("Vvedite chisla massiva.");

			for (int i = 0; i < 10; i++)
			{
				mas[i] = Convert.ToInt32(Console.ReadLine());
				if (mas[i] > 0)
				{
					polNum++;
					srZnach = srZnach + mas[i];
				}
			}

			srZnach = Math.Round(srZnach / polNum);

			Console.WriteLine("V massive 10 peremennih, " + "iz kotorih " + polNum + " polozhitelnih." + "\nI ih srednee znachenie - " + srZnach + ".");
		}
	}
}
