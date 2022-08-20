using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORU 1
            Console.Write("Bir pozitif sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir pozitif sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            #endregion

            #region SORU 2
            Console.Write("Bir pozitif sayı giriniz: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Bir pozitif sayı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                Console.Write("Bir pozitif sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                if (m == sayi || sayi % m == 0)
                {
                    Console.WriteLine(sayi);
                }
                //}
                #endregion

                #region SORU 3
                Console.Write("Bir pozitif sayı giriniz: ");
                int l = int.Parse(Console.ReadLine());
                ArrayList kelimeler = new ArrayList();
                for (int j = 0; j < l; j++)
                {
                    Console.Write("Bir kelime giriniz: ");
                    string kelime = Console.ReadLine();
                    kelimeler.Add(kelime);
                }
                kelimeler.Reverse();
                foreach (var klime in kelimeler)
                {
                    Console.WriteLine($"{klime} ");
                }
                #endregion

                #region SORU 4
                Console.WriteLine("Bir cümle giriniz: ");
                string cumle = Console.ReadLine();
                string[] kelimeSayisi = cumle.Split(' ');
                Console.WriteLine($"Kelime sayısı: {kelimeSayisi.Count()}");
                Console.WriteLine($"Harf sayısı: {cumle.Count()}");
                #endregion
                Console.ReadLine();
            }
        }
    }
}
