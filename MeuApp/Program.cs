using System.Globalization;

class Program {

    public static void Main(string[] args) {

        // Localização e Globalização de Data e Hora

        Console.Clear();

        var dateTime = DateTime.UtcNow; // hora global

        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime.ToLocalTime());

        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.Write(timezoneAustralia.ToString());

        var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
        Console.WriteLine(horaAustralia);

        // lista todos os tempos cadastrados.
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            Console.WriteLine("--------------");
        }

    }

   
}