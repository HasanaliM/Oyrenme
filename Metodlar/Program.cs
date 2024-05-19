namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mehsulAdi = "Alma";
            double qiymeti = 3;
            string melumat = "Qizil Ehmet";

            Mehsul mehsul1 = new Mehsul();
            mehsul1.Adi = "Alma";
            mehsul1.Qiymeti = 3;
            mehsul1.Melumat = "Qizil Ehmet";

            Mehsul mehsul2 = new Mehsul();
            mehsul2.Adi = "Qarpiz";
            mehsul2.Qiymeti = 4;
            mehsul2.Melumat = "Sabirabad Qarpizi";

            Mehsul[] mehsullar = new Mehsul[] {mehsul1, mehsul2 };

            foreach (Mehsul mehsul in mehsullar)
            {

                Console.WriteLine(mehsul.Adi);
                Console.WriteLine(mehsul.Qiymeti);
                Console.WriteLine(mehsul.Melumat);
                Console.WriteLine("-----------------");    
            }

            Console.WriteLine("----------Metodlar----------");
            
            // instance - numune
            // encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(mehsul1);
            sepetManager.Ekle(mehsul2);

            sepetManager.Ekle2("Armud", "Yasil Armud", 5, 8);
            sepetManager.Ekle2("Alma", "Yasil Alam", 5, 6);
            sepetManager.Ekle2("Qarpiz", "Sabirabad Qarpizi", 5, 7);

        }
    }
}
