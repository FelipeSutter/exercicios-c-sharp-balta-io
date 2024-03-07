class Program {

    const int INITIAL_TIME = 1;

    static void Start(int totalTime) {

        for (int i = INITIAL_TIME; i <= totalTime; i++) {
            Console.Clear();
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Stopwatch finalizado...");
        Thread.Sleep(2000);
    }

    static int Menu() {
        int time;
        do {
            Console.Clear();
            Console.WriteLine("Bem-vindo(a) ao Stopwatch C-Sharp!");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Em quanto tempo deseja contar? ");
            
            string data = Console.ReadLine().ToString();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = type == 'm' ? 60 : 1;

            Start(time * multiplier);

        } while (time != 0);
        return time;
    }

    public static void Main(string[] args) {
        bool isMenuActive = true;
        while (isMenuActive) {
            int option = Menu();
            if (option == 0) {
                isMenuActive = false;
            }
        }
    }


}