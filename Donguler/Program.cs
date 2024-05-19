using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "Yazilim Gelistirici Yetisdirme Kampi";
        string kurs2 = "Programlamay Baslangis Icin Temel Kurs";
        string kurs3 = "Java";
        //array - dizi list
        string[] kurslar = new string[] { "Yazilim Gelistirici Yetisdirme Kampi", "C#", "Programlamay Baslangis Icin Temel Kurs", "Java" };
        for (var i = kurslar.Length; i < 0 ; i--)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("For bitti");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
            
        }
        Console.WriteLine("Sayfa Sonu - footer");











        /*int[] lamanTask = { 12, 3, 78, 27, 9, 44, 3, 72, 82, 78, 78, 23, 99, 67, 9, 81 };
        int minimumNetice = lamanTask[0];
        for (int i = 0; i < lamanTask.LongLength; i++)
        {
            if ((lamanTask[i]%2 ==0))           
            {
                Console.WriteLine( lamanTask[i]);
               
            }
            
        } */
            
  
    }   
}
