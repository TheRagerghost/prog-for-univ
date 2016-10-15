using System;

namespace HW15_10_16
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int k, l, m, n;

			Console.WriteLine("Vvedite kol-vo strok, a zatem stolbcov matrici 1.");

			k = Convert.ToInt32(Console.ReadLine());
			l = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Vvedite kol-vo strok, a zatem stolbcov matrici 2.");

			m = Convert.ToInt32(Console.ReadLine());
			n = Convert.ToInt32(Console.ReadLine());

			int[,] matrix1 = new int[k, l];
			int[,] matrix2 = new int[m, n];
			Random rnd = new Random();

			if (k == n)
			{
				for (int i = 0; i < l; i++)
				{
					for (int j = 0; j < k; j++)
					{
						matrix1[i, j] = rnd.Next(-5, 5);
					}
				}

				for (int i = 0; i < l; i++)
				{
					for (int j = 0; j < k; j++)
					{
						matrix2[i, j] = rnd.Next(-5, 5);
					}
				}

				int[,] matrix3 = new int[l, m];

				for (int i = 0; i < m; i++)
				{
					for (int j = 0; j < l; j++)
					{
						matrix3[i, j] = 0;
						for (int f = 0; f < k; f++)
						{
							matrix3[i, j] += matrix1[i, j] * matrix2[i,j];
						}
					}
				}

				for (int i = 0; i < m; i++)
				{
					for (int j = 0; j < l; j++)
					{
						Console.WriteLine(matrix3[i, j]);
					}

				}

			}
			else {
				Console.WriteLine("Nelzya peremnozhit!");
			}


		}
	}
}
