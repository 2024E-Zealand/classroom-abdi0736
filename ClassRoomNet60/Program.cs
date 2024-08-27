// See https://aka.ms/new-console-template for more information

using ClassRoomNet60;

Console.WriteLine("Hello, World!");

{
    static void Main(string[] args)
    {
        List<Studerende> studerendeListe = new List<Studerende>();
        
        studerendeListe.Add(new Studerende("Abdi", 12, 2002));
        studerendeListe.Add(new Studerende("Ali", 12, 2003));
        studerendeListe.Add(new Studerende("Saad", 9, 2004));


        KlasseRum klasseRum = new KlasseRum("3B", studerendeListe, new DateTime(2022, 9, 1));
        
        Console.WriteLine($"KlasseNavn: {klasseRum.KlasseNavn}");
        Console.WriteLine($"SemesterStart: {klasseRum.SemesterStart.ToShortDateString()}");
        Console.WriteLine("Studerende i klassen:");
        foreach (var studerende in klasseRum.Klasseliste)
        {
            Console.WriteLine($"{studerende.Navn}, Karakter: {studerende.Fødselmåned}, Fødselsår: {studerende.Fødselsår}");
        }
    }
}

public class Studerende
{
    public string Navn { get; set; }
    public int Fødselmåned{ get; set; }
    public int Fødselsår { get; set; }

    public Studerende(string navn, int fødselmåned, int fødselsår)
    {
        Navn = navn;
        Fødselmåned = fødselmåned;
        Fødselsår = fødselsår;
    }
}

public class KlasseRum
{
    public string KlasseNavn { get; set; }
    public List<Studerende> Klasseliste { get; set; }
    public DateTime SemesterStart { get; set; }

    public KlasseRum(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
    {
        KlasseNavn = klasseNavn;
        Klasseliste = klasseliste;
        SemesterStart = semesterStart;
    }
}