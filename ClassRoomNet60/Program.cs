// See https://aka.ms/new-console-template for more information

using ClassRoomNet60;

 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Studerende> studerendeListe = new List<Studerende>
            {
                new Studerende("Abdi", 12, 2002),
                new Studerende("Ali", 12, 2003),
                new Studerende("Saad", 9, 2004),
                new Studerende("Dani", 3, 2002),  
                new Studerende("Rebin", 6, 2003), 
                new Studerende("AB", 7, 2004),   
                new Studerende("Mat", 11, 2001),
                new Studerende("Hus", 2, 2000), 
                new Studerende("Lade", 5, 2005)
            };

            KlasseRum klasseRum = new KlasseRum("3B", studerendeListe, new DateTime(2022, 9, 1));

            Console.WriteLine($"KlasseNavn: {klasseRum.KlasseNavn}");
            Console.WriteLine($"SemesterStart: {klasseRum.SemesterStart.ToShortDateString()}");
            Console.WriteLine("Studerende i klassen:");
            foreach (var studerende in klasseRum.Klasseliste)
            {
                Console.WriteLine($"{studerende.Navn}, Fødselmåned: {studerende.Fødselmåned}, Fødselsår: {studerende.Fødselsår}, Årstid: {studerende.Årstid()}");
            }

         
            klasseRum.TælFødselsdageIÅrstider();
        }
    }

    public class Studerende
    {
        public string Navn { get; set; }
        public int Fødselmåned { get; set; }
        public int Fødselsår { get; set; }

        public Studerende(string navn, int fødselmåned, int fødselsår)
        {
            Navn = navn;
            Fødselmåned = fødselmåned;
            Fødselsår = fødselsår;
        }

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

        public void TælFødselsdageIÅrstider()
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
