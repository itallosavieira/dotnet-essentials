using System;

namespace EditorHtml
{
	public static class Menu
	{
		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.White;

			DrawScreen(40, 20);
			WriteOptions();

			var option = short.Parse(Console.ReadLine());
			HandleMenuOption(option);
		}

		static void DrawLine(char sidesFill, char middleFill, short size)
		{
			Console.Write(sidesFill);
			for(int i = 0; i <= size - 1; i++)
			{
				Console.Write(middleFill);
			}
			Console.Write(sidesFill);
			Console.Write('\n');
		}
		public static void DrawScreen(short columns, short lines)
		{
			DrawLine('*', '-', columns);
			for(int i = 0; i <= lines - 1; i++)
			{
				DrawLine('|', ' ', columns);
			}
			DrawLine('*', '-', columns);
		}

		static void WriteTextInPosition(string text, short line, short column)
		{
			Console.SetCursorPosition(line, column);
			Console.Write(text);
		}
		public static void WriteOptions()
		{
			WriteTextInPosition("HTML Editor", 3, 2);
			WriteTextInPosition("===========", 3, 3);
			WriteTextInPosition("Select an option bellow:", 3, 5);
			WriteTextInPosition("1 - New File", 3, 7);
			WriteTextInPosition("2 - Open File", 3, 8);
			WriteTextInPosition("0 - Exit", 3, 9);
			WriteTextInPosition("Option: ", 3, 11);
		}

		public static void HandleMenuOption(short option)
		{
			switch(option) {
				case 1: Editor.Show(); break;
				case 2: Console.WriteLine("View"); break;
				case 0: {
					Console.Clear();
					Environment.Exit(0);
					break;
				}
				default: Show(); break;
			}
		}
	}
}
