using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alanını hesaplamak istediğiniz şekil: \n1)Daire \n2)Eşkenar Üçgen \n3)Kare");
            int sekil = int.Parse(Console.ReadLine());
            switch (sekil)
            {
                case 1:
                    Daire();
                    break;
                    case 2:
                    Ucgen();
                    break;
                    case 3:
                    Kare();
                    break;
            }
            Console.ReadLine();
        }

        public static void Daire()
        {
            Console.WriteLine("Yarıçapı giriniz: ");
            int yaricap = int.Parse(Console.ReadLine());
            double daireAlan = (double)Math.Pow(yaricap,2) * 3.14;
            Console.WriteLine(daireAlan);
        }
        public static void Ucgen()
        {
            Console.WriteLine("Kenar giriniz: ");
            int kenar = int.Parse(Console.ReadLine());
            double ucgen = (Math.Sqrt(3) * kenar) / 4;
            Console.WriteLine(ucgen);
        }
        public static void Kare()
        {
            Console.WriteLine("Kenar giriniz: ");
            int kenar = int.Parse(Console.ReadLine());
            double kare = Math.Pow(kenar,2);
            Console.WriteLine(kare);
        }
    }
}
