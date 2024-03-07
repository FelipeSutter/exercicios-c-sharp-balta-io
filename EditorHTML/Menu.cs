namespace EditorHTML;
internal class Menu {

    public static void Show() {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());

        HandleMenuOptions(option); 
    }

    private static void DrawUpAndDownLines() {
        Console.Write("+");
        for (int i = 0; i <= 30; i++) {
            Console.Write("-");
        }
        Console.Write("+\n");
    }

    private static void DrawMidLines() {
        for (int i = 0; i <= 10; i++) {
            Console.Write("|");
            for (int j = 0; j <= 30; j++) {
                Console.Write(" ");
            }
            Console.Write("|\n");

        }
    }
    
    private static void WriteOptions() {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("===========");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(2, 7);
        Console.WriteLine("3 - Sair");
        Console.SetCursorPosition(2, 10);
        Console.Write("Opção: ");
    }

    private static void DrawScreen() {

        DrawUpAndDownLines();

        DrawMidLines();

        DrawUpAndDownLines();

    }

    private static void HandleMenuOptions(short option) {
        switch (option) {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 3: {
                Console.Clear();
                Environment.Exit(0); 
                break;
            }
            default: Show(); break;
        }
    }

}
