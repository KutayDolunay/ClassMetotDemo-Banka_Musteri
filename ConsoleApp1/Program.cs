using ClassMetotDemo;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Komutları kullanmak için aşağıdaki numaraları girin:");

        MusteriManager musteriManager = new MusteriManager();
        List<Musteri> musteriler = new List<Musteri>();


        Musteri musteri1 = new Musteri(1, "Kutay", "Dolunay");
        Musteri musteri3 = new Musteri(2, "Sultan", "Bulut");
        Musteri musteri2 = new Musteri(3, "Berk", "Gunay");
        Musteri musteri4= new Musteri(4, "Öykü", "Cömert");

        musteriManager.MusterileriEkle(musteri1, musteri2, musteri3, musteri4);


        while (true)
        {
            
            Console.WriteLine("1: Müşterileri Listele");
            Console.WriteLine("2: Müşteri Ekle");
            Console.WriteLine("3: Müşteri Sil");
            Console.WriteLine("0: Çıkış");

            if (int.TryParse(Console.ReadLine(), out int komut))
            {
                switch (komut)
                {
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    case 1:
                        musteriManager.MusteriListele();
                        break;
                    case 2:
                        Console.Write("Müşteri Adı: ");
                        string ad = Console.ReadLine();
                        Console.Write("Müşteri Soyadı: ");
                        string soyad = Console.ReadLine();
                        Console.Write("Müşteri ID'sini girin: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            Musteri yeniMusteri = new Musteri(id, ad, soyad);
                            musteriManager.MusteriEkle(yeniMusteri);
                            musteriler.Add(yeniMusteri);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ID girdiniz.");
                        }
                        break;
                    case 3:
                        Console.Write("Silinecek müşteri ID'sini girin: ");
                        if (int.TryParse(Console.ReadLine(), out int silinecekMusteriId))
                        {
                            Musteri silinecekMusteri = musteriler.Find(m => m.Id == silinecekMusteriId);
                            if (silinecekMusteri != null)
                            {
                                musteriManager.MusteriSil(silinecekMusteriId);
                                musteriler.Remove(silinecekMusteri);
                            }
                            else
                            {
                                Console.WriteLine("Müşteri bulunamadı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ID girdiniz.");
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz komut. Lütfen geçerli bir komut numarası girin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz komut. Lütfen geçerli bir komut numarası girin.");
            }
        }
    }
}
