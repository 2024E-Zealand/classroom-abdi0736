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
}