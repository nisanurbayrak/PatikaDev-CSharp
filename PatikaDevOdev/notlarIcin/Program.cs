using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notlarIcin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c = new Calisan ("Ali", "Veli", 13432, "C#101" );
            Ogrenci o = new Ogrenci();

            o.OgrenciBilgi("Nisa", "Bayrak", 0);
            o.SinifAtla();
            Console.WriteLine(o.Sinif);

            Console.WriteLine(Ogrenciler.ogrenciSayisi);
            Ogrenciler o2 = new Ogrenciler("Nisa", "Bayrak");
            Ogrenciler o3 = new Ogrenciler("Nisa", "Bayrak");
            Console.WriteLine(Ogrenciler.ogrenciSayisi);
            Console.WriteLine("sonuc = {0}", Islemler.Topla(2, 3));

            Dikdortgen dgen = new Dikdortgen();
            dgen.kisaKenar = 3; // değer atamazsan default atar.
            dgen.uzunKenar = 5;
            Console.WriteLine(dgen.AlanHesapla());

            //DikdortgenStruct dgens;
            //dgens.kisaKenar = 3;
            //dgens.uzunKenar = 5;
            DikdortgenStruct dgens = new DikdortgenStruct(3,5); // değer ataman gerekir.
            Console.WriteLine(dgens.AlanHesapla());

            Console.WriteLine(Gunler.pazartesi);
            Console.WriteLine((int)Gunler.cumartesi);
            int sicaklik = 22;
            if (sicaklik > (int)HavaDurumu.Soguk)
            {
                Console.WriteLine("hava: "+ (int)HavaDurumu.CokSicak);
            }
        }
        #region 1
        public class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman) // parametre isteyen kurucu metot
            {
                Ad = ad;
                Soyad = soyad;
                No = no;
                Departman = departman;
            }
            public void Bilgi()
            {
                Console.WriteLine("Çalışan Adı : {0}", Ad);
            }
        }
        //1.Public : Her yerden erişilebilir.
        //2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
        //3.Internal : Sadece bulunduğu proje içerisinden erişilebilir
        //4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

        //yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
        //1.Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
        //2.Public olarak bildirilmeleri gerekir.
        //3.Geri dönüş değerleri yoktur. (void yazmazsın)
        #endregion
        #region 2
        public class Ogrenci
        {
            private string ad;
            public string Soyad;
            private int sinif;

            public string Ad
            {
                get { return ad; }
                set { ad = value; }
            }

            public int Sinif
            {
                get => sinif;
                set
                {
                    if (sinif < 1)
                    {
                        Console.WriteLine("sınıf en az 1 olmalı");
                        sinif = 1;
                    }
                    else
                    {
                        sinif = value;
                    }
                }
            }

            public Ogrenci(string soyad)
            {
                soyad = Soyad;
            }
            public Ogrenci() { }
            public void OgrenciBilgi(string ad, string soyad, int sinif)
            {
                ad = Ad;
                soyad = Soyad;
                Sinif = sinif;          
            }
            public void SinifAtla()
            {
                this.Sinif += 1;
            }
        }
        #endregion
        #region 3
        class Ogrenciler
        {
            public static int ogrenciSayisi;
            public static int OgrenciSayisi { get => ogrenciSayisi; }
            private string ad;
            private string soyad;
            static Ogrenciler()
            {
                ogrenciSayisi = 0;
            }
            public Ogrenciler(string Ad, string Soyad) 
            {
                this.ad = Ad;
                this.soyad = Soyad;
                ogrenciSayisi++;
            }
        }
        static class Islemler
        {
            public static long Topla(int s1, int s2)
            {
                return s1 + s2;
            }
            public static long Cikar(int s1, int s2)
            {
                return s1 - s2;
            }
        }
        #endregion
        #region 4 Struct 
        // Classlar referans tipli özellikler gösterir  |  Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
        // Diğer struct ya da sınıflardan kalıtım almazlar.
        // Interface'lerden kalıtım alabilirler.
        // new anahtar sözcüğü ile nesneleri yaratılabilir.
        // Sınıflar gibi metot, property ve field'lardan oluşurlar.
        // Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
        // Static üye barındırabilirler.
        class Dikdortgen
        {
            public int kisaKenar;
            public int uzunKenar;
            public Dikdortgen()
            {
                kisaKenar = 3;
                uzunKenar = 5;
            }
            public long AlanHesapla()
            {
                return this.kisaKenar * this.uzunKenar;
            }
        }
        struct DikdortgenStruct
        {
            public int kisaKenar;
            public int uzunKenar;
            public DikdortgenStruct(int kKenar, int uKenar)
            {
                kisaKenar = kKenar;
                uzunKenar = uKenar;
            }
            public long AlanHesapla()
            {
                return this.kisaKenar * this.uzunKenar;
            }
        }
        #endregion
        #region 5
        enum Gunler
        {
            pazartesi = 3, sali, carsamba, persembe, cuma, cumartesi, pazar
        }
        enum HavaDurumu
        {
            Soguk = -15, CokSicak = 30
        }
        #endregion
    }
}
