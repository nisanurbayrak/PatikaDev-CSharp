using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru 1
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList nasalsayilar = new ArrayList();
            ArrayList asalsayilar = new ArrayList();
            int j;
            int nasalTop = 0;
            int asalTop = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("bir sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());

                for (j = 2; j <= sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        asalsayilar.Add(sayi);
                        break;
                    }
                }
                if (i == sayi)
                {
                    nasalsayilar.Add(sayi);
                }
            }
            asalsayilar.Sort();
            asalsayilar.Reverse();
            foreach (int asal in asalsayilar)
            {
                Console.WriteLine(asal);
                asalTop = asalTop + asal;
            }
            nasalsayilar.Sort();
            nasalsayilar.Reverse();
            foreach (int nasal in nasalsayilar)
            {
                Console.WriteLine(nasal);
                nasalTop = nasalTop + nasal;
            }
            Console.WriteLine($"Asal Sayılar Listesi Eleman Sayısı: {asalsayilar.Count} Ortalaması: {asalTop / asalsayilar.Count}");
            Console.WriteLine($"Nasal Sayılar Listesi Eleman Sayısı: {nasalsayilar.Count} Ortalaması: {nasalTop / nasalsayilar.Count}");
            #endregion
            #region Soru 2
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            int[] sayilar = new int[20];
            int[] buyuksayi = new int[3];
            int[] kucuksayi = new int[3];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("bir sayı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayilar);
            kucuksayi[0] = sayilar[0];
            kucuksayi[1] = sayilar[1];
            kucuksayi[2] = sayilar[2];
            int topla = 0;
            int btopla = 0;
            foreach (int sayi in kucuksayi)
            {
                Console.WriteLine(sayi);
                topla = topla + sayi;
            }
            Console.WriteLine($"küçük sayı toplamı: {topla} \n küçük sayı ortalama = {topla / 3}");
            buyuksayi[0] = sayilar[17];
            buyuksayi[1] = sayilar[18];
            buyuksayi[2] = sayilar[19];
            foreach (int sayi in buyuksayi)
            {
                Console.WriteLine(sayi);
                btopla = topla + sayi;
            }
            Array.Sort(buyuksayi);
            Console.WriteLine($"büyük sayı toplamı: {btopla} \n büyük sayı ortalama = {btopla / 3}");
            #endregion

            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            ArrayList sesliHarf = new ArrayList();
            Console.WriteLine("cümle giriniz: ");
            char[] cumle = (Console.ReadLine().ToCharArray());
            Console.WriteLine($"cümle içerisindeki sesli harfler");
            foreach (char c in cumle)
            {
                if (c == 'a' || c == 'e' || c == 'ı' || c == 'i' || c == 'u' || c == 'ü' || c == 'o' || c == 'ö')
                {
                    sesliHarf.Add(c);
                    Console.WriteLine(c);
                }
            }
            
        }
    }
}
