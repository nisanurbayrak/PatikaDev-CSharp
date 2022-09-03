using System;

public class Classlar
{
    public Classlar()
    {
        1.Public : Her yerden erişilebilir.
        2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
        3.Internal : Sadece bulunduğu proje içerisinden erişilebilir
        4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

        yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
        1.Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
        2.Public olarak bildirilmeleri gerekir.
        3.Geri dönüş değerleri yoktur. (void yazmazsın)


        Calisan c = new Calisan("Ali", "Veli", 13432, "C#101");
        c.CasisanBilgileri();
        public Calisan(string ad, string soyad, int no, string departman) // parametre isteyen kurucu metot
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }
    }
}
