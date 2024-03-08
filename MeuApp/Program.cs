using System.Globalization;

class Program {

    public static void Main(string[] args) {

        // Localização e Globalização de Data e Hora

        Console.Clear();

        Console.WriteLine(DateTime.DaysInMonth(2020, 2));
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

    }

    // verificar se é final de semana, sábado e domingo
    static bool IsWeekend(DayOfWeek day)
    {
        return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
    }

   
}