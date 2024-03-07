using System.Text;

namespace EditorHTML;
internal class Editor {

    public static void Show() {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        
        Console.WriteLine("Modo Editor");
        Console.WriteLine("-----------");

        Start();

    }

    public static void Start() {
        var file = new StringBuilder();

        do {
            file.Append(Console.ReadLine());
            file.Append("\n");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-----------");
        Console.WriteLine(" Deseja salvar o arquivo?");

        Viewer.Show(file.ToString());

    }
}
