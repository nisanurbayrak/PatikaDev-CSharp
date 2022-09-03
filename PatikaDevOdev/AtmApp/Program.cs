using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmApp;
using static AtmApp.Kullanici;

namespace AtmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            int sayac = 0;
            while (cikis != true)
            {
                Console.Write("KullanıcıAdı: ");
                string kAd = Console.ReadLine();
                Console.Write("Şifre: ");
                string kSifre = Console.ReadLine();
                Kullanici bulunanKullanici = Dataa.KullaniciTablo.Find(i => i.KullaniciAdi == kAd && i.Sifre == kSifre);

                if (bulunanKullanici != null)
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi seçin: \n 1)Para yatırma \n 2)Para çekme \n 3)Giriş Kontrol");
                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            Kullanici kullanici = new Kullanici();
                            Console.WriteLine($"yatırdığınız para = {tutar}");
                            break;
                        case "2":
                            Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
                            int eksi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"çektiğiniz para = -{eksi}");
                            break;
                        case "3":
                            Console.WriteLine($"hatalı giriş sayınız: {sayac}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hata.");
                    sayac += 1;
                    Console.Write("Çıkmak istiyormusunuz (E/H)");
                    char cikmak = Convert.ToChar(Console.ReadLine());
                    if (cikmak == 'e' || cikmak == 'E')
                    {
                        cikis = true; return;
                    }
                    else
                    {
                        cikis = false;
                    }
                }

            }
            
        }
    }
}
