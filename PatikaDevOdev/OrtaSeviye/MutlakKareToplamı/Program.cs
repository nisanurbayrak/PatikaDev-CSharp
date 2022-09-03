using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakKareToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("dizinizi oluşturun: ");
            string elemanlar = Console.ReadLine();
            int sayi = 0, toplam = 0, fark = 0;
            string[] dizi = elemanlar.Split(',');
            for (int i = 0; i < dizi.Length; i++)
            {
                sayi = Convert.ToInt16(dizi[i]);
                if (sayi < 67)
                {
                    fark = (67 - sayi) + fark;
                }
                else
                {
                    toplam = (int)Math.Pow(Math.Abs(sayi - 67), 2);
                }
            }
            Console.WriteLine(fark + toplam);
        }
    }
}
