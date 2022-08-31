using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\r\n *******************************************\r\n  " +
                "(1) Yeni Numara Kaydetmek\r\n  " +
                "(2) Varolan Numarayı Silmek\r\n  " +
                "(3) Varolan Numarayı Güncelleme\r\n  " +
                "(4) Rehberi Listelemek\r\n  " +
                "(5) Rehberde Arama Yapmak﻿");
            string secim = Console.ReadLine();
            Dictionary<string, string> Kisi = new Dictionary<string, string>();
            Kisi.Add("Dilara", "3452331214");
            Kisi.Add("Ahmet", "4567345467");
            Kisi.Add("Meryem", "734545467");
            Kisi.Add("Can", "35745435");
            Kisi.Add("Veli", "4567345467");
            switch (secim)
            {
                case "1":
                    Console.Write("Ad Soyad: ");
                    string Ad = Console.ReadLine();
                    Console.Write("Numara: ");
                    string Numara = Console.ReadLine();
                    Kisi.Add(Ad , Numara);
                    Console.WriteLine("Ekleme işlemi başarılı.");
                    break;
                case "2":
                    Console.Write("Silmek istediğiniz kişi: ");
                    string SilinecekKisi = Console.ReadLine();
                    Kisi.Remove(SilinecekKisi);
                    foreach (var kişi in Kisi)
                    {
                        Console.WriteLine(kişi);
                    }
                    Console.WriteLine("Silme işlemi başarılı.");
                    break;
                case "3":
                    Console.Write("Güncellemek istediğiniz kişinin adını yazın: ");
                    string GAd = Console.ReadLine();
                    int count = 0;
                    foreach (var numara in Kisi)
                    {
                        bool kontrol = numara.Key.Contains(GAd);
                        if (kontrol == true)
                        {
                            Console.Write("Ad Soyad: ");
                            string GuncelleneckAd = Console.ReadLine();
                            Console.Write("Numara: ");
                            string GuncellenecekNumara = Console.ReadLine();
                            Kisi.Remove(GAd);
                            Kisi.Add(GuncelleneckAd, GuncellenecekNumara);
                            Console.WriteLine("Güncelleme işlemi başarılı.");
                            break;
                        }
                        else
                        {
                            count++;
                            continue;
                        }
                    }
                    if (Kisi.Count == count)
                    {
                        Console.WriteLine("Kayıt bulunamadı.");
                    }
                    break;
                case "4":
                    foreach (var numara in Kisi)
                    {
                        Console.WriteLine(numara);
                    }
                    break;
                case "5":
                    Console.Write("Aramak istediğiniz kişiyi yazınız: ");
                    string ArananKisi = Console.ReadLine();
                    foreach (var arananKisi in Kisi)
                    {
                        if (arananKisi.Key.Contains(ArananKisi))
                        {
                            Console.WriteLine($"{ arananKisi.Key} {arananKisi.Value}");
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
