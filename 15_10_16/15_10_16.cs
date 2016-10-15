using System;

namespace HW15_10_16
{
	class MainClass
	{   

		public static void Main(string[] args)
		{
			Random rnd = new Random();

			int randNum = rnd.Next(0, 10);

			int ansNum;

			int mistNum = 0;

			Console.WriteLine("Число загадано!");

			for (int i = 0; i < 3; i++)
			{
				int n = 3;
				int l = n - i;

				if (l > 1)
				{
					Console.WriteLine("У вас осталось " + l + " попытки!");
				}
				else {
					Console.WriteLine("У вас осталaсь 1 попыткa!");
				}

				ansNum = Convert.ToInt32(Console.ReadLine());

				if (randNum == ansNum)
				{
					Console.WriteLine("Верно!");
					break;
				}
				else {
					Console.WriteLine("Неверно!");
					mistNum++;
				}

			}

			switch (mistNum)
			{
				case 0:
					Console.WriteLine("Да ты просто бог!");
					break;
					
				case 1:
					Console.WriteLine("Красавчик!");
					break;
					
				case 2:
					Console.WriteLine("Неплохо!");
					break;
					
				case 3:
					Console.WriteLine("Фу, лах! Верное число: " + randNum);
					break;
			}


		
		}
	}
}
