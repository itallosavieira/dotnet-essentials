using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}
		static void Menu()
		{
			Console.Clear();

			Console.WriteLine("Hello!");
			Console.WriteLine("1 - Sum");
			Console.WriteLine("2 - Sub");
			Console.WriteLine("3 - Mul");
			Console.WriteLine("4 - Div");
			Console.WriteLine("5 - Exit");

			Console.WriteLine("----------------");
			Console.WriteLine("Select operation");

			short res = short.Parse(Console.ReadLine());

			switch (res)
			{
				case 1: Sum(); break;
				case 2: Sub(); break;
				case 3: Mul(); break;
				case 4: Div(); break;
				case 5: System.Environment.Exit(0); break;
				default: Menu(); break;
			}
		}
		static void Sum()
		{
			Console.Clear();

			Console.WriteLine("First Number:");
			float n1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Second Number:");
			float n2 = float.Parse(Console.ReadLine());

			float result = n1 + n2;
			Console.WriteLine("Result: " + result);

			Console.ReadKey();
			Menu();
		}

		static void Sub()
		{
			Console.Clear();

			Console.WriteLine("First Number:");
			float n1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Second Number:");
			float n2 = float.Parse(Console.ReadLine());

			float result = n1 - n2;
			Console.WriteLine("Result: " + result);

			Console.ReadKey();
			Menu();
		}
		static void Mul()
		{
			Console.Clear();

			Console.WriteLine("First Number:");
			float n1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Second Number:");
			float n2 = float.Parse(Console.ReadLine());

			float result = n1 * n2;
			Console.WriteLine("Result: " + result);

			Console.ReadKey();
			Menu();
		}
		static void Div()
		{
			Console.Clear();

			Console.WriteLine("First Number:");
			float n1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Second Number:");
			float n2 = float.Parse(Console.ReadLine());

			float result = n1 / n2;
			Console.WriteLine("Result: " + result);

			Console.ReadKey();
			Menu();
		}
	}
}
