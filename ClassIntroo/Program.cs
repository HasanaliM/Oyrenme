namespace ClassIntroo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hasanali Mammadov";
            kurs1.BilmeDerecesi = 15;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Js";
            kurs2.Egitmen = "Laman Cabbarova";
            kurs2.BilmeDerecesi = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Nigar Abbasova";
            kurs3.BilmeDerecesi = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)

            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }


    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int BilmeDerecesi { get; set; }
    }
}
