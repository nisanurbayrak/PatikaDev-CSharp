using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmApp;

namespace AtmApp
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

    }
}

public class Dataa
{
    public static List<Kullanici> KullaniciTablo = new List<Kullanici>();
    static Dataa()
    {
        KullaniciTablo.Add(new Kullanici()
        {
            KullaniciAdi = "uye",
            Sifre = "123",
        }) ;
    }
}

