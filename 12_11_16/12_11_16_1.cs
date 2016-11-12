using System;

namespace _11_16HW
{
	class MainClass
	{ 

		public static void Main(string[] args)
		{
	        int _i;
			int _m;
			int _l;
			int _prev = 0;
			int _d = 0, _dd = 0;
			int _result1 = 0, _result2 = 0;
			bool _prov = false, _ready = false;
			Console.WriteLine("Set the length of array:");
			int.TryParse(Console.ReadLine(), out _i);
			int[] mas = new int [_i];
			for ( int _n = 0; _n < _i ;_n++ ){
				_l = _n + 1;
				Console.WriteLine("Vvedite peremennuyu #{0}", _l);
				int.TryParse(Console.ReadLine(), out _m);
				mas[_n] = _m;
			}

			for (int _n = 0; _n < _i; _n++)
			{
				

				if (_d == 0 && _prev != 0)
				{
					_d = mas[_n] - _prev;
					_dd = mas[_n] / _prev;
					Console.WriteLine("D and DD: " + _d);
					Console.WriteLine(_dd);

					_ready = true;
				}

		      if (_d == 0 && _prev == 0)
				{
					_prev = mas[_n];
					Console.WriteLine("Prev: " + _prev);
				}

				if (_ready) {
					_result1 = mas[_n] - _prev;
					_result2 = mas[_n] / _prev;
					Console.WriteLine("Res1 and Res2: " + _result1);
					Console.WriteLine(_result2);

					if (_result1 == _d)
					{
						_prov = true;
					}
					else if (_result2 == _dd)
					{
						_prov = true;
					}
					else {
						_prov = false;
					}

					if (!_prov)
					{
						break;
					}
				}


				_prev = mas[_n];

			}

			if(!_prov){
				Console.WriteLine("Array is not a poslyedovatelnost");
			} else {
				Console.WriteLine("Array is a poslyedovatelnost");
			}

			for (int _n = 0; _n < _i; _n++)
			{
				Console.WriteLine(" | {0} | ", mas[_n]);
			}


		}
	}
}
