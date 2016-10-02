using System;

namespace ProgUniv
{
	public class Vector3
	{
		public double x;
		public double y;
		public double z;

		public Vector3(double nx, double ny, double nz)
		{
			x = nx;
			y = ny;
			z = nz;
		}

		//Сложение векторов
		public void addVector(double newx, double newy, double newz)
		{
			x = x + newx;
			y = y + newy;
			z = z + newz;
		}


		//Модуль вектора
		public void vectorModule()
		{
			double mod = Math.Sqrt(x * x + y * y + z * z);
			Console.WriteLine("Your vector module is " + mod);
		}


		//Поворот вектора. В процессе разработки...
		public void vecRot()
		{
			double radCorrection = Math.PI / 180;
			double modXYZ = Math.Sqrt(x * x + y * y + z * z);

			Console.WriteLine("Set 'x' degree:");
			double xdeg = ((Convert.ToDouble(Console.ReadLine()) * radCorrection) + Math.Asin(y / modXYZ)) % (2 * Math.PI);
			Console.WriteLine("Set 'y' degree:");
			double ydeg = ((Convert.ToDouble(Console.ReadLine()) * radCorrection) + Math.Asin(z / modXYZ)) % (2 * Math.PI);
			Console.WriteLine("Set 'z' degree:");
			double zdeg = ((Convert.ToDouble(Console.ReadLine()) * radCorrection) + Math.Asin(x / modXYZ)) % (2 * Math.PI);


			double sinx = Math.Sin(xdeg);
			double cosx = Math.Sqrt(1 - (sinx * sinx));
			double siny = Math.Sin(ydeg);
			double cosy = Math.Sqrt(1 - (siny * siny));
			double sinz = Math.Sin(zdeg);
			double cosz = Math.Sqrt(1 - (sinz * sinz));


			y = Math.Round(modXYZ * sinx);
			z = Math.Round(modXYZ * siny);
			x = Math.Round(modXYZ * sinz);

			Console.WriteLine(modXYZ);
			Console.WriteLine("\n\n" + xdeg + "\n" + ydeg + "\n" + zdeg);
			Console.WriteLine("\n\n" + sinx + "\n" + cosx);
			Console.WriteLine("\n\n" + siny + "\n" + cosy);
			Console.WriteLine("\n\n" + sinz + "\n" + cosz);
		}
	}
	class MainClass
	{


		public static void Main(string[] args)
		{
			Console.WriteLine("X=?");
			double nx = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Y=?");
			double ny = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Z=?");
			double nz = Convert.ToDouble(Console.ReadLine());
			Vector3 myVector = new Vector3(nx,ny,nz);
			double moduleXYZ = Math.Sqrt(myVector.x * myVector.x + myVector.y * myVector.y + myVector.z * myVector.z);
			if (moduleXYZ > 0)
			{
				Console.WriteLine("Your Vector is (" + myVector.x + "," + myVector.y + "," + myVector.z + ").");

				Console.WriteLine("Something else? (AddNew or RotateVector or ShowModule or Nothing)");

				string answer = Console.ReadLine();

				switch (answer)
				{
					case "AddNew":
						Console.WriteLine("New X=?");
						double newx = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("New Y=?");
						double newy = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("New Z=?");
						double newz = Convert.ToDouble(Console.ReadLine());
						myVector.addVector(newx, newy, newz);
						Console.WriteLine("Final Vector is (" + myVector.x + "," + myVector.y + "," + myVector.z + ").");
						break;

					case "RotateVector":
						myVector.vecRot();
						Console.WriteLine("Your Vector is (" + myVector.x + "," + myVector.y + "," + myVector.z + ").");
						break;

					case "ShowModule":
						myVector.vectorModule();
						break;

					case "Nothing":
						Console.WriteLine("Final Vector is (" + myVector.x + "," + myVector.y + "," + myVector.z + ").");
						break;

					default:
						Console.WriteLine("Final Vector is (" + myVector.x + "," + myVector.y + "," + myVector.z + ").");
						break;

				}
			}
			else
			{
				Console.WriteLine("There is no vector(");
			}

		}
	}
}
