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

			//11111111111111111111111111111111111111111111111111111111111111

            Console.WriteLine("*******************************************");
			Console.WriteLine("1111111111111111111111111111111111111111111");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			int _m, _n;
			Random _random = new Random();
			_m = _random.Next(3, 9);
			_n = _random.Next(4, 12);
			int[,] _mas1 = new int[_m, _n];        //Объявляю массив

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					_mas1[i, j] = _random.Next(0, 9);     //Заплняю его
				}
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);    //Вывожу его в консоль (*1*)
				}
				Console.WriteLine();
				Console.WriteLine();
			}




			//22222222222222222222222222222222222222222222222222222222222222

			Console.WriteLine("*******************************************");
			Console.WriteLine("2222222222222222222222222222222222222222222");
			Console.WriteLine("*******************************************");
			Console.WriteLine();
			Console.WriteLine();

			int[] _nemas = new int[_n];          //Объявляю вспомогательный массив для обратного порядка

			for (int i = 0; i < _n; i++)
			{
				_nemas[i] = _mas1[0, (_n - 1 - i)];      //Заполняю его обратным первым рядом
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[0, i] = _nemas[i];                 //Заменяю первый ряд обратным из вспомогательного массива
			}

			for (int i = 0; i < _n; i++)
			{
				_nemas[i] = _mas1[(_m - 1), (_n - 1 - i)];    //Заполняю вспомогательный обратным последним рядом
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[(_m - 1), i] = _mas1[0, i];           //Заменяю последний ряд первым
			}

			for (int i = 0; i < _n; i++)
			{
				_mas1[0, i] = _nemas[i];                //Заменяю первый ряд обратным последним
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);          //(*1*)
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			//33333333333333333333333333333333333333333333333333333333333333

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
						_min = _mas1[i, j];             //Нахожу первый минимальный элемент массива, а также пересекающиеся
						_mini = i;                      //ряд и
						_minj = j;                      //столбец
					}
				}
			}

			int[,] _helpmas = new int[_m - 1, _n - 1];  //Объявляю вспомогательный двумерный массив

			for (int i = 0; i < _m; i++)                           //Вывожу в него 
			{
				for (int j = 0; j < _n; j++)
				{
					if (i > _mini && j > _minj)
					{
						_helpmas[i - 1, j - 1] = _mas1[i, j];      //нижнюю правую четверть  
					}
					else if (i > _mini && j < _minj)
					{
						_helpmas[i - 1, j] = _mas1[i, j];          //нижнюю левую четверть
					}
					else if (i < _mini && j > _minj)
					{
						_helpmas[i, j - 1] = _mas1[i, j];          //верхнюю правую четверть
					}
					else if (i < _mini && j < _minj)
					{
						_helpmas[i, j] = _mas1[i, j];              //верхнюю левую четверть
					}
				}
			}

			_m--;                                                  //Так как в C# отсутствуют динамические массивы,
			_n--;                                                  //то попросту переобъявляю старый массив,
			_mas1 = new int[_m, _n];                               //укоротив его на 1 ряд и 1 столбец

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					_mas1[i, j] = _helpmas[i, j];                  //Присваиваю значения вспомогательного массива основному
				}
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);           //(*1*)
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			//44444444444444444444444444444444444444444444444444444444444444

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
									"\n 3. Massiv dolzhen bit zakrit tochkoy v konce.", _n);
			_newmas = Console.ReadLine();                                                         //Считываю строку


			//В случае возникновения ошибки из-за неправильно введенной строки программа выдаст ошибку
			//и завершит процесс

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

			int[,] _mas2 = Massivate(_newmas);            //Происходит преобразование строки в двумерный массив
			_nm = _mas2.GetUpperBound(0) + 1;             
			_nn = _mas2.GetUpperBound(1) + 1;

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Ishodniy massiv");
			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _n; j++)
				{
					Console.Write("{0}  ", _mas1[i, j]);  //(*1*)
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			Console.WriteLine("Vash massiv");
			for (int i = 0; i < _nm; i++)
			{
				for (int j = 0; j < _nn; j++)
				{
					Console.Write("{0}  ", _mas2[i, j]);  //Вывожу преобразованный из строки массив
				}
				Console.WriteLine();
				Console.WriteLine();
			}

			//55555555555555555555555555555555555555555555555555555555555555

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
						_mas3[i, j] += _mas1[i,k] * _mas2[k,j];       //Перемножаю массивы
					}
				}
			}

			for (int i = 0; i < _m; i++)
			{
				for (int j = 0; j < _nn; j++)
				{
					Console.Write("{0}  ", _mas3[i, j]);              //Вывожу получившийся массив
				}
				Console.WriteLine();
				Console.WriteLine();
			}
		}

		public static int[,] Massivate(string _string){
			int _nm = 0, _nn = 0;
			string[] _mainsep = new string[] { "." };               //Создаю разделители
			string[] _rowsep = new string[] { "," };
			string[] _columnsep = new string[] { " " };
			string[] _rowsmas;
			string[] _readyToMassivate;
			string _newstring;
			_readyToMassivate = _string.Split(_mainsep,StringSplitOptions.RemoveEmptyEntries); //Разделяю строку до первой точки
			_newstring = _readyToMassivate[0];
			List<string> _rows = new List<string>();
			_readyToMassivate = _newstring.Split(_rowsep, StringSplitOptions.RemoveEmptyEntries); //Разделяю остаток строки на ряды
			int l = _readyToMassivate.Length;

			for (int i = 0; i < l;i++){
				_rows.Add(_readyToMassivate[i]);                                                 //Добавляю ряды в список
			}

			_rowsmas = _rows.ToArray();                                                          //Преобразовываю список в массив
			_nm = l;
			_readyToMassivate = _rowsmas[0].Split(_columnsep, StringSplitOptions.RemoveEmptyEntries); //Разделяю первый ряд на числа
			_nn = _readyToMassivate.Length;                                                           //Считаю количество чисел
            int[,] _massivated = new int[_nm, _nn];                                                   //Объявляю массив 

			for (int i = 0; i < _nm; i++)
			{
				_readyToMassivate = _rowsmas[i].Split(_columnsep, StringSplitOptions.RemoveEmptyEntries);   //Разделяю все ряды на числа
				for (int j = 0; j < _nn; j++){
					_massivated[i, j] = Convert.ToInt32(_readyToMassivate[j]);                        //Записываю в массив числа
				}
			}
			return _massivated;                                                                     //Возвращаю массив
		}

		public static bool CheckString(string _string, int n){
			int l = 0;
			int m = 0, k = 0;
			bool _isNormal = false;                                                 //Ввожу ряд проверяющих булов
			bool _hasEnd = false;
			bool _equalLines = false;
			bool _sameLength = true;
			foreach (char element in _string){

				if (Convert.ToInt32(element) == Convert.ToInt32(' '))  
				{
					k++;                                                            //Считаю пробелы
				}

				if (Convert.ToInt32(element) == Convert.ToInt32(',')){
					l++;                                                            //Считаю ряды
					if (m == 0)                                                     //Далее провожу сравнение количества пробелов
					{                                                               //Каждый пробел - это переход к новому числу
						m = k;                                                      //От них напрямую зависит длина рядов
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
					_hasEnd = true;                                                 //Проверяю наличие точки
					l++;
					if (m == k)
					{
						k = 0;
					}
					else if (m != k)
					{
						_sameLength = false;
					}
					break;                                                           //Выхжу из цикла по достижении точки
				}
			}

			if(l==n && _sameLength){
				_equalLines = true;
			}

			if (_hasEnd&&_equalLines){
				_isNormal = true;
			}
				return _isNormal;                                                     //Возвращаю результат проверки
		}
	}
}
