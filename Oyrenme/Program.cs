string konsolEtiketi = ("Katagoriler");
int ogrenciSayi = 10000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 1.69;
double dolarBugun = 1.70;
if (dolarDun > dolarBugun)
{
    Console.WriteLine("Dolar Azaldi");
}

else if (dolarDun < dolarBugun) 
{
    Console.WriteLine("Dolar Artdi");
}
else
{
    Console.WriteLine("Dolar Ayni Kaldi");
}
if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Sisteme Giris Yapdiniz");
    
}
else
{
    Console.WriteLine("Lutfen Giris Yapiniz");
}