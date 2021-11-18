using System;
using System.Threading;

namespace Timer
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu() {
			Console.Clear();

			Console.WriteLine("S - Seconds => 10s = 10 seconds");
			Console.WriteLine("M - Minutes => 2m = 2 minutes");
			Console.WriteLine("0 - Exit");
			Console.WriteLine("Type:");

			string data = Console.ReadLine().ToLower();
			char type = char.Parse(data.Substring(data.Length - 1, 1));
			int time = int.Parse(data.Substring(0, data.Length - 1));
			int multiplier = 1;

			if (type == 'm')
				multiplier = 60;

			if (time == 0 || time < 0)
				System.Environment.Exit(0);

			PreStart();
			Start(time * multiplier);
			Menu();
		}

		static void PreStart()
		{
			Console.Clear();

			Console.WriteLine("Ready...");
			Thread.Sleep(1500);
			Console.WriteLine("Set...");
			Thread.Sleep(1500);
			Console.Clear();
			Console.WriteLine("Go!");
			Thread.Sleep(2000);
		}
		static void Start(int time)
		{
			Console.Clear();

			while (time >= 0)
			{
				Console.Clear();
				Console.WriteLine(time);
				time--;
				Thread.Sleep(1000);
			}
			Console.Clear();
			Console.WriteLine("End...");
			Thread.Sleep(2000);
		}
	}
}
