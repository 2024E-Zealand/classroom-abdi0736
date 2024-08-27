namespace ClassRoomNet60;

public class Studerende
{
    public Studerende(string navn, int fødselmåned, int fødselår)
    {
        Navn = navn;
        Fødselmåned = fødselmåned;
        Fødselår = fødselår;
    }

    private string Navn { get; set; }
    private int Fødselmåned { get; set; }
    private int Fødselår { get; set; }
    
    public string Årstid()
    {
        if (Fødselmåned == 12 || Fødselmåned == 1 || Fødselmåned == 2)
        {
            return "Vinter";
        }
        else if (Fødselmåned >= 3 && Fødselmåned <= 5)
        {
            return "Forår";
        }
        else if (Fødselmåned >= 6 && Fødselmåned <= 8)
        {
            return "Sommer";
        }
        else if (Fødselmåned >= 9 && Fødselmåned <= 11)
        {
            return "Efterår";
        }
        else
        {
            return "Ugyldig måned";
        }
    }
    
}