using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using System.Linq;

namespace KolaySeviyeHepsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    System.Console.WriteLine("Fibonacci derlemesi için sayısı giriniz");
            //    int sayi = Int32.Parse(Console.ReadLine());
            //    Dizi(sayi);
            Ucgen();
            //Silme();
            Reverse();
            Console.Read();
        }
        public static void Dizi(int len)
        {
            int d1 = 0;
            int d2 = 1;
            int d3 = 0;
            List <int> list = new List<int>();
            for (int i = 0; i < len; i++)
            {
                d3 = d1 + d2;
                list.Add(d3);
                d1 = d2;
                d2 = d3;
                var result = list.Sum();
            }
        }
        public static void Ucgen()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("^");
                }
                Console.WriteLine("");
            }
        }
        public static void Silme()
        {
            string[] sMetin;
            Console.Write("Metin: ");
            string s = Console.ReadLine();
            sMetin = s.Split(','); for (int i = 0; i < sMetin[0].Length; i++)
            {
                if (i != Convert.ToInt32(s.Length))
                {
                    var find = s.IndexOf(",");
                    s = s.Remove(find, find + 1);
                    i++;
                }
                Console.WriteLine(s);
            }
        }
        public static void Reverse()
        {
            Console.WriteLine("Cümle: ");
            string cumle = Console.ReadLine();
            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                Console.Write(cumle[i]);
            }
        }
    }
}