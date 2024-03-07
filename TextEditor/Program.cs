class Program {

    static void AbrirArquivo() {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path)) {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine();
        Thread.Sleep(2000);

    }

    static void EditarArquivo() {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("-----------------------");
        string text = "";

        // Enquanto não apertar ESC
        do {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(text);
        Thread.Sleep(3000);

    }

    static void Salvar(string text) {
        Console.Clear();

        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        // Serve para abrir e fechar automaticamente o objeto aqui dentro
        using (var file = new StreamWriter(path)) {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo salvo no caminho {path} com sucesso!");


    }

    static int Menu() {
        int opcao;
        do {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Escolha a sua opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "1");
        } while (opcao < 1 || opcao > 3);
        return opcao;
    }

    public static void Main(string[] args) {

        bool isMenuActive = true;
        while (isMenuActive) {
            switch (Menu()) {
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    EditarArquivo();
                    break;
                case 3:
                    isMenuActive = false;
                    break;
            }
        }
    }


}