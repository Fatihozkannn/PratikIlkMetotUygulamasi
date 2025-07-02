using System;

class Program
{
    static void Main()
    {
        // 1. Geriye değer döndürmeyen void metot → Şarkı sözü yazdırıyor
        SarkisozuYaz();

        // 2. Geriye tamsayı döndüren metot → Rastgele sayı üretip 2'ye bölümden kalanını döndürüyor
        int kalan = CiftlikKalan();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);

        // 3. Parametre alan ve geriye değer döndüren metot → İki sayının çarpımını döndürür
        int carpimSonucu = Carpim(4, 5);
        Console.WriteLine("4 ve 5'in çarpımı: " + carpimSonucu);

        // 4. Parametre alan ve geriye değer döndürmeyen metot → İsmi alıp hoş geldiniz yazdırır
        Karsilama("Fatih", "Özkan");
    }

    // 1. Geriye değer döndürmeyen metot (void)
    static void SarkisozuYaz()
    {
        Console.WriteLine("Bir derdim var artık tutamam içimde...");
    }

    // 2. Geriye tamsayı döndüren metot
    static int CiftlikKalan()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 100); // 1-99 arası sayı üretir
        return sayi % 2; // 2’ye bölümünden kalan döner (0 ya da 1)
    }

    // 3. Parametre alan ve geriye değer döndüren metot
    static int Carpim(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // 4. Parametre alan ve geriye değer döndürmeyen metot
    static void Karsilama(string isim, string soyisim)
    {
        Console.WriteLine("Hoş Geldiniz " + isim + " " + soyisim);
    }
}
