using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("KullanıcıAdı: ");
            string kAd = Console.ReadLine();
            Console.Write("Şifre: ");
            string kSifre = Console.ReadLine();
            int hp = 0;
            int lotr = 0;   
            Kullanici bulunanKullanici = Dataa.KullaniciTablo.Find(i => i.KullaniciAdi == kAd && i.Sifre == kSifre);
            if (bulunanKullanici != null)
            {
                Console.WriteLine("Oy vermek istediğiniz filmi seçin. \n1)LOTR \n2)HarryPotter");
                int secim1 = int.Parse(Console.ReadLine());
                switch (secim1)
                {
                    case 1:
                        lotr++;
                        Console.WriteLine($"Oyunuzla birlikte {lotr} oy toplandı.");
                        break;
                    case 2:
                        hp++;
                        Console.WriteLine($"Oyunuzla birlikte {hp} oy toplandı.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş.");
            }
        }
    }
}
