using System;
using System.Collections;
using System.Collections.Generic;

public class GenericKoleksiyon
{
	public GenericKoleksiyon()
	{
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.ForEach(x => Console.ReadLine()); //
        list.Contains(1);
        list.BinarySearch(2);


        string[] harfler = { "a", "b", "c" };
        List<string> harfList = new List<string>(harfler); //

        Kullanici kullanici = new Kullanici();
        kullanici.Name = "Ayşe";
        kullanici.ID = 123;

        Kullanici kullanici2 = new Kullanici();
        kullanici2.Name = "Fatma";
        kullanici2.ID = 124;

        List<Kullanici> kullanicis = new List<Kullanici>();
        kullanicis.Add(new Kullanici
        {
            Name = "Ali",
            ID = 125
        });
    }
    public class Kullanici
    {
        private string name;
        private string lastName;
        private int id;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int ID { get => id; set => id = value; }
    }
}
