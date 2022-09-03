using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümlenizi girin: ");
            string cumle = Console.ReadLine();
            bool kont = false;
            foreach (var item in cumle.Split(' '))
            {
                for (int i = 1; i < item.Length; i++)
                {
                    if (kontrol(item[i]) == kontrol(item[i-1]))
                    {
                        kont = true;
                    }                
                    Console.WriteLine($"{kont} ");
                }
            }
            bool kontrol(char c)
            {
                return !"aeıioöuü".ToCharArray().Contains(c);
            }
        }
    }
}
