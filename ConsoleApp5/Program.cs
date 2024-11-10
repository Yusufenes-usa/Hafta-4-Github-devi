/*
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan taban uzunluğu ve yükseklik alınıyor
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double taban = double.Parse(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini girin: ");
        double yukseklik = double.Parse(Console.ReadLine());

        // Metodu çağırarak üçgenin alanını hesapla
        double alan = UcgeninAlaniHesapla(taban, yukseklik);

        // Sonucu ekrana yazdır
        Console.WriteLine("Üçgenin alanı: " + alan);
    }

    // Üçgenin alanını hesaplayan metot
    static double UcgeninAlaniHesapla(double taban, double yukseklik)
    {
        double alan = (taban * yukseklik) / 2;
        return alan;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
  
        int[] sayilar = { 10, 25, 3, 7, 50, 12 };

        int enBuyukSayi = EnBuyukDegerBul(sayilar);

        // Sonucu ekrana yazdır
        Console.WriteLine("Dizideki en büyük sayı: " + enBuyukSayi);
    }

   
    static int EnBuyukDegerBul(int[] dizi)
    {
        int enBuyuk = dizi[0]; 

      
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i]; 
            }
        }

        return enBuyuk; 
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        // Farklı türdeki metotları çağırarak toplamlarını buluyoruz
        int toplamIkiInt = Topla(10, 20);                 // İki int değerin toplamı
        double toplamDouble = Topla(5.5, 4.5);            // İki double değerin toplamı
        int toplamUcInt = Topla(10, 20, 30);              // Üç int değerin toplamı

        // Sonuçları ekrana yazdırma
        Console.WriteLine("İki int sayının toplamı: " + toplamIkiInt);
        Console.WriteLine("İki double sayının toplamı: " + toplamDouble);
        Console.WriteLine("Üç int sayının toplamı: " + toplamUcInt);
    }

    // İki int değerin toplamını bulan metot
    static int Topla(int a, int b)
    {
        return a + b;
    }

    // İki double değerin toplamını bulan metot
    static double Topla(double a, double b)
    {
        return a + b;
    }

    // Üç int değerin toplamını bulan metot
    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci dizisinde kaçıncı terimi görmek istiyorsunuz? ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n}. Fibonacci terimi: {Fibonacci(n)}");

        // İsterseniz Fibonacci dizisinin ilk n terimini yazdırabilirsiniz
        Console.WriteLine("İlk " + n + " terim:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    // Recursive Fibonacci metodu
    static int Fibonacci(int n)
    {
        // Baz durum: ilk iki Fibonacci sayıları
        if (n == 1 || n == 2)
            return 1;

        // Recursive çağrı
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        // Farklı sayıda parametre göndererek ortalamayı hesapla
        Console.WriteLine("Ortalama (3, 5, 7): " + OrtalamaHesapla(3, 5, 7));
        Console.WriteLine("Ortalama (2, 4, 6, 8, 10): " + OrtalamaHesapla(2, 4, 6, 8, 10));
        Console.WriteLine("Ortalama (15, 20): " + OrtalamaHesapla(15, 20));
    }

    // Sınırsız sayıda parametre alarak ortalama hesaplayan metot
    static double OrtalamaHesapla(params double[] sayilar)
    {
        double toplam = 0;

        // Tüm sayıları topla
        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }

        // Sayıların ortalamasını hesapla ve döndür
        return toplam / sayilar.Length;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int[] sayilar = { 1, 5, 10, 15, 20, 25, 30 };

        // Örneğin 10'dan büyük sayıları topla
        int sonuc = Toplam(sayilar, x => x > 10);

        Console.WriteLine("10'dan büyük sayıların toplamı: " + sonuc);

        // Örneğin çift sayıları topla
        sonuc = Toplam(sayilar, x => x % 2 == 0);

        Console.WriteLine("Çift sayıların toplamı: " + sonuc);
    }

    // Dizi elemanlarını belirli bir şarta göre toplayan metot
    static int Toplam(int[] dizi, Func<int, bool> filtre)
    {
        int toplam = 0;

        // Filtreyi uygulayarak toplama işlemi
        foreach (int sayi in dizi)
        {
            if (filtre(sayi)) // Şart sağlanıyorsa
            {
                toplam += sayi;
            }
        }

        return toplam;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan yaş bilgisi alıyoruz
        Console.Write("Yaşınızı girin: ");
        int yas = int.Parse(Console.ReadLine());

        // Varsayılan olarak 18 yaşı kullanarak ne kadar fazla olduğunu hesaplar
        int fazlaYil = YasFarkiHesapla(yas);

        Console.WriteLine("18 yaşından sonraki fazla yıl sayısı: " + fazlaYil);

        // Eğer farklı bir başlangıç yaşı kullanmak isterseniz, örneğin 21
        fazlaYil = YasFarkiHesapla(yas, 21);
        Console.WriteLine("21 yaşından sonraki fazla yıl sayısı: " + fazlaYil);
    }

    // Yaş farkını hesaplayan metot
    static int YasFarkiHesapla(int yas, int baslangicYasi = 18)
    {
        if (yas <= baslangicYasi)
            return 0; // Yaş başlangıç yaşına eşit veya küçükse fark yoktur.

        return yas - baslangicYasi;
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Test verisi
        string[] kelimeler = { "elma", "karpuz", "kiraz", "çilek", "armut", "ananas" };

        // Metodu çağırarak 5 karakterden büyük kelimeleri filtreleyip listeyi alıyoruz
        List<string> filtrelenmisKelimeler = FiltreliListeOlustur(kelimeler);

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("5 karakterden büyük kelimeler:");
        foreach (string kelime in filtrelenmisKelimeler)
        {
            Console.WriteLine(kelime);
        }
    }

    // 5 karakterden büyük elemanları filtreleyip döndüren metot
    static List<string> FiltreliListeOlustur(string[] dizi)
    {
        List<string> sonuc = new List<string>();

        foreach (string eleman in dizi)
        {
            if (eleman.Length > 5)
            {
                sonuc.Add(eleman);
            }
        }

        return sonuc;
    }
}
*/
