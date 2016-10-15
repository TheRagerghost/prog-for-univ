using System;

namespace HW15_10_16
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double farCoeff = 1.8f;
			double kelvCoeff = 273.15f;
			int variant;
			double gradus;
			double convertedGradus;

			Console.WriteLine("Kakoy perevod vi hotite provesti?" +
			                  "\n(1) Cel => Far" +
			                  "\n(2) Cel => Kel" +
			                  "\n(3) Far => Cel" +
			                  "\n(4) Far => Kel" +
			                  "\n(5) Kel => Cel" +
			                  "\n(6) Kel => Far");
			variant = Convert.ToInt32(Console.ReadLine());

			switch (variant)
			{
				case 1:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = gradus * farCoeff + 32;
					convertedGradus = Math.Round(convertedGradus,1);
					Console.WriteLine(gradus + " po Celsiyu raven " + convertedGradus + " po Farengeitu");
					break;

					case 2:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = gradus + kelvCoeff;
					convertedGradus = Math.Round(convertedGradus, 1);
					Console.WriteLine(gradus + " po Celsiyu raven " + convertedGradus + " po Kelvinu");
					break;

					case 3:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = (gradus - 32)/ farCoeff;
					convertedGradus = Math.Round(convertedGradus, 1);
					Console.WriteLine(gradus + " po Farengeitu raven " + convertedGradus + " po Celsiyu");
					break;

					case 4:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = (gradus - 32) / farCoeff + kelvCoeff;
					convertedGradus = Math.Round(convertedGradus, 1);
					Console.WriteLine(gradus + " po Farengeitu raven " + convertedGradus + " po Kelvinu");
					break;

					case 5:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = gradus  - kelvCoeff;
					convertedGradus = Math.Round(convertedGradus, 1);
					Console.WriteLine(gradus + " po Kelvinu raven " + convertedGradus + " po Celsiyu");
					break;

					case 6:
					Console.WriteLine("Vvedite gradus:");
					gradus = Convert.ToDouble(Console.ReadLine());
					convertedGradus = (gradus - kelvCoeff) * farCoeff + 32;
					convertedGradus = Math.Round(convertedGradus, 1);
					Console.WriteLine(gradus + " po Kelvinu raven " + convertedGradus + " po Farengeitu");
					break;

				default:
					Console.WriteLine("Net takogo varianta!");
					break;
			}
			

		}
	}
}
