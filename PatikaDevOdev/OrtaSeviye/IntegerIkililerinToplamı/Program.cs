using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerIkililerinToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 2, 3, 1, 5, 2, 5, 3, 3 };
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] == dizi[i+1])
                {
                    double toplam = dizi[i] + dizi[i + 1];
                    double kare = Math.Pow(toplam, 2);
                    Console.WriteLine(kare);
                    i++;
                }
                else
                {
                    int toplam = dizi[i] + dizi[i + 1];
                    Console.WriteLine(toplam);
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}
