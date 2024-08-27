namespace ClassRoomNet60;

public class KlasseRum
{
    public KlasseRum(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
    {
        KlasseNavn = klasseNavn;
        Klasseliste = klasseliste;
        SemesterStart = semesterStart;
    }

    private string KlasseNavn { get; set; }
    private List<Studerende> Klasseliste { get; set; }
    private DateTime SemesterStart { get; set; }
    
    public void FødselsdagesÅrstider()
    {
        var vinterCount = Klasseliste.Count(s => s.Årstid() == "Vinter");
        var forårCount = Klasseliste.Count(s => s.Årstid() == "Forår");
        var sommerCount = Klasseliste.Count(s => s.Årstid() == "Sommer");
        var efterårCount = Klasseliste.Count(s => s.Årstid() == "Efterår");

        Console.WriteLine("Antal studerende med fødselsdag i hver årstid:");
        Console.WriteLine($"Vinter: {vinterCount}");
        Console.WriteLine($"Forår: {forårCount}");
        Console.WriteLine($"Sommer: {sommerCount}");
        Console.WriteLine($"Efterår: {efterårCount}");
    }
}