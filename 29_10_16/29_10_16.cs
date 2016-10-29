using System;

namespace _10_16HW
{
	class MainClass
	{
		public static string hexValues;
		public static bool isHexadecimal;

		public static void Main(string[] args)
		{
			
			Console.WriteLine("Write line:");
			hexValues = Console.ReadLine();
			Console.WriteLine("Is it a Hexadecimal number?");
			foreach (Char hex in hexValues)
			{
				
				int _0val = Convert.ToInt32('0');
				int _9val = Convert.ToInt32('9');
				int _Aval = Convert.ToInt32('A');
				int _Fval = Convert.ToInt32('F');
				int value = Convert.ToInt32(hex);
				//string stringValue = Char.ConvertFromUtf32(value);
				//Console.WriteLine("{0} {1} {2} {3} {4} {5}", _0val , _9val, _Aval, _Fval, value, stringValue);


				if(value >= _0val && value <= _9val){
					isHexadecimal = true;

				} else if (value >= _Aval && value <= _Fval){
					isHexadecimal = true;

				} else {
					isHexadecimal = false;
					break;
				}

			}

			if(isHexadecimal){
				Console.WriteLine("It is Hexadecimal");
			} else {
				Console.WriteLine("It is not Hexadecimal");
			}



		}
	}
}
