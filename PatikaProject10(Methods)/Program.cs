using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Geriye değer döndürmeyen bir void metot çağrısı
        SarkiSozuYazdir();

        // 2. Geriye tamsayı döndüren bir metot çağrısı
        int kalan = RastgeleSayiVeKalan();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);

        // 3. Parametre alan ve geriye değer döndüren bir metot çağrısı
        int carpimSonucu = IkiSayiyiCarp(8, 10);
        Console.WriteLine("İki sayının çarpımı: " + carpimSonucu);

        // 4. Parametre alan ve geriye değer döndürmeyen bir metot çağrısı
        HosGeldinizMesaji("Furkancan", "Yılmaz");
    }

    // 1. Geriye değer döndürmeyen bir void metot
    static void SarkiSozuYazdir()
    {
        Console.WriteLine("Sevdiğim şarkı sözü: 'Saygımdan birazda seni unutmaya kıyamadıysam.'");
    }

    // 2. Geriye tamsayı döndüren bir metot
    static int RastgeleSayiVeKalan()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 101); // 1 ile 100 arasında rastgele sayı üretir
        return sayi % 2; // 2'ye bölümünden kalan
    }

    // 3. Parametre alan ve geriye değer döndüren bir metot
    static int IkiSayiyiCarp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // 4. Parametre alan ve geriye değer döndürmeyen bir metot
    static void HosGeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }
}
