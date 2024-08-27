namespace ClassRoomNet60;

public class Studerende
{
    public Studerende(string navn, int fødselsmåned, int fødselår)
    {
        Navn = navn;
        Fødselsmåned = fødselsmåned;
        Fødselår = fødselår;
    }

    private string Navn { get; set; }
    private int Fødselsmåned { get; set; }
    private int Fødselår { get; set; }
    
}