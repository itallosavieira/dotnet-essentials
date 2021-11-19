using System;
using System.IO;

namespace TextEditor
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
			Console.WriteLine("1 - Open File");
			Console.WriteLine("2 - Create New File");
			Console.WriteLine("0 - Exit");

			short option = short.Parse(Console.ReadLine());

			switch(option)
			{
				case 0: System.Environment.Exit(0); break;
				case 1: OpenFile(); break;
				case 2: EditFile(); break;
				default: Menu(); break;
			}
		}

		static void OpenFile()
		{
			Console.Clear();
			Console.WriteLine("Wahst the path to the file?");
			Console.WriteLine("---------------------------");

			string path = Console.ReadLine();

			using(var file = new StreamReader(path))
			{
				string text = file.ReadToEnd();
				Console.WriteLine(text);
			}

			Console.ReadLine();
			Menu();
		}

		static void EditFile()
		{
			Console.Clear();
			Console.WriteLine("Type your text above (ESC to exit)");
			Console.WriteLine("----------------------------------");

			var text = "";

			do
			{
				text += Console.ReadLine();
				text += Environment.NewLine;
			}
			while(Console.ReadKey().Key != ConsoleKey.Escape);

			SaveFile(text);
		}

		static void SaveFile(string text)
		{
			Console.Clear();
			Console.WriteLine("Type a path with your file name - /Users/file.ex");

			var fileName = Console.ReadLine();

			using (var file = new StreamWriter(fileName))
			{
				file.Write(text);
			}

			Console.WriteLine($"File {fileName} saved successfully.");
			Thread.Sleep(2000);
			Menu();
		}
	}
}
