/*

  ИКБО-08-16 Вишняков Андрей
  

  Осталось: добавить комментарии и вообще немного привести код в порядок.

*/





using System;
using System.Collections.Generic;

namespace MassiveWorks
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int _m, _n;

			Random _random = new Random();
			_m = _random.Next(3, 9);
			_n = _random.Next(4, 12);
			int[,] _mas1 = new int[_m, _n];


			//1111111111111111111111111111111111111111111111111111

			Console.WriteLine("*******************************************");
			Console.WriteLine("1111111111111111111111111111111111111111111");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					_mas1[i, j] = _random.Next(0, 9);
				}
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			//22222222222222222222222222222222222222222222222222222

			Console.WriteLine("*******************************************");
			Console.WriteLine("2222222222222222222222222222222222222222222");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			int[] _nemas = new int[_n];

			for (int i = 0; i < _n; i++)
			{
				_nemas[i] = _mas1[0, (_n - 1 - i)];
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[0, i] = _nemas[i];
			}

			for (int i = 0; i < _n; i++)
			{
				_nemas[i] = _mas1[(_m - 1), (_n - 1 - i)];
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[(_m - 1), i] = _mas1[0, i];
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[0, i] = _nemas[i];
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			//3333333333333333333333333333333333333333333333333333333

			Console.WriteLine("*******************************************");
			Console.WriteLine("3333333333333333333333333333333333333333333");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			int _min = 10, _mini = 0, _minj = 0;

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					if (_mas1[i, j] < _min)
					{
						_min = _mas1[i, j];
						_mini = i;
						_minj = j;
					}
				}
			}

			int[,] _helpmas = new int[_m - 1, _n - 1];

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{

					if (i > _mini && j > _minj)
					{
						_helpmas[i - 1, j - 1] = _mas1[i, j];
					}
					else if (i > _mini && j < _minj)
					{
						_helpmas[i - 1, j] = _mas1[i, j];
					}
					else if (i < _mini && j > _minj)
					{
						_helpmas[i, j - 1] = _mas1[i, j];
					}
					else if (i < _mini && j < _minj)
					{
						_helpmas[i, j] = _mas1[i, j];
					}
				}
			}






			_m--;
			_n--;
			_mas1 = new int[_m, _n];

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					_mas1[i, j] = _helpmas[i, j];
				}
			}



			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}


			//4444444444444444444444444444444444444444444444444444444

			Console.WriteLine("*******************************************");
			Console.WriteLine("4444444444444444444444444444444444444444444");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			string _newmas = "";


			int _nm = 0, _nn = 0;

			Console.WriteLine("Vvedite svoy massiv. (Optimalnoye kolichestvo strok - {0})" +
									"\n 1. Vse elementi dolzhni bit razdeleni probelom." +
									"\n 2. Vse stroki dolzhni bit razdeleni zapyatimi." +
									"\n 3. Massiv dolzhen bit zakrit tochkoy v konce.", _n); 			_newmas = Console.ReadLine();

			try
			{
				if (!CheckString(_newmas, _n))
				{
					throw new Exception("Vi dopustili oshibku pri vvode massiva, pozhaluysta ubedites, chto:" +
									"\n 1. Vse elementi razdeleni probelom." +
									"\n 2. Vse stroki razdeleni zapyatimi." +
									"\n 3. Massiv zakrit tochkoy v konce.");
				}
			}
			catch (Exception e)
			{
				Console.Write("{0}", e.Message);
				Environment.Exit(0);
			}


			int[,] _mas2 = Massivate(_newmas);
			_nm = _mas2.GetUpperBound(0) + 1;
			_nn = _mas2.GetUpperBound(1) + 1;
			//Console.WriteLine(_nn);


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Ishodniy massiv");
			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			Console.WriteLine("Vash massiv");
			for (int i = 0; i < _nm; i++)
			{
				for (int j = 0; j < _nn; j++)
				{
					Console.Write("{0}  ", _mas2[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}


			//555555555555555555555555555555555555555555555555555555555
			Console.WriteLine("*******************************************");
			Console.WriteLine("5555555555555555555555555555555555555555555");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			int[,] _mas3 = new int[_m, _nm];

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _nn; j++)
				{
					_mas3[i, j] = 0;
					for (int k = 0; k < _n;k++)
					{
						_mas3[i, j] += _mas1[i,k] * _mas2[k,j];
					}
				}
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _nn; j++)
				{
					Console.Write("{0}  ", _mas3[i, j]);
				}
				Console.WriteLine();
				Console.WriteLine();
			}
		}


		public static int[,] Massivate(string _string){
			int _nm = 0, _nn = 0;
			string[] _mainsep = new string[] { "." };
			string[] _rowsep = new string[] { "," };
			string[] _columnsep = new string[] { " " };
			string[] _rowsmas;
			string[] _readyToMassivate;
			string _newstring;
			_readyToMassivate = _string.Split(_mainsep,StringSplitOptions.RemoveEmptyEntries);
			_newstring = _readyToMassivate[0];

			List<string> _rows = new List<string>();
			_readyToMassivate = _newstring.Split(_rowsep, StringSplitOptions.RemoveEmptyEntries);
			int l = _readyToMassivate.Length;

			for (int i = 0; i < l;i++){
				_rows.Add(_readyToMassivate[i]);
			}

			_rowsmas = _rows.ToArray();

			_nm = l;
			_readyToMassivate = _rowsmas[0].Split(_columnsep, StringSplitOptions.RemoveEmptyEntries);
			_nn = _readyToMassivate.Length;

            int[,] _massivated = new int[_nm, _nn];

			for (int i = 0; i < _nm; i++)
			{
				_readyToMassivate = _rowsmas[i].Split(_columnsep, StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < _nn; j++){
					_massivated[i, j] = Convert.ToInt32(_readyToMassivate[j]);
				}
			}

			return _massivated;
		}

		public static int Converter (string number){
			int i = 0;
			i = Convert.ToInt32(number);
			return i;
		}

		public static bool CheckString(string _string, int n){
			int l = 0;
			int m = 0, k = 0;
			bool _isNormal = false;
			bool _hasEnd = false;
			bool _equalLines = false;
			bool _sameLength = true;
			foreach (char element in _string){

				if (Convert.ToInt32(element) == Convert.ToInt32(' '))
				{
					k++;
				}

				if (Convert.ToInt32(element) == Convert.ToInt32(',')){
					l++;
					if (m == 0)
					{
						m = k;
						k = 0;
					}
					else if (m == k)
					{
                        k = 0;
					}
					else if (m != k)
					{
						_sameLength = false;
					}

				} else if (Convert.ToInt32(element) == Convert.ToInt32('.')){
					_hasEnd = true;
					l++;
					if (m == k)
					{
						k = 0;
					}
					else if (m != k)
					{
						_sameLength = false;
					}
					break;
				}
					
			}

			if(l==n && _sameLength){
				_equalLines = true;
			}

			if (_hasEnd&&_equalLines){
				_isNormal = true;
			}

				return _isNormal;
		}

	}
}
