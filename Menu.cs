using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch(option) {
                case 1: Editor.Show();
                break;
                case 2: Console.WriteLine("View");
                break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    Console.Clear();
                }
                break;
                default: Show();
                break;
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("============");
            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void DrawScreen(int setColumns, int setLines)
        {
           TopAndBottomScreen(setColumns);

            for (int lines = 0; lines <= setLines; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= setColumns; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

           TopAndBottomScreen(setColumns);

        }

        public static void TopAndBottomScreen(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++) Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
    }
} 