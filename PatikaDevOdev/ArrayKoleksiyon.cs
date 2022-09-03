using System;

public class ArrayKoleksiyon
{
	public ArrayKoleksiyon()
	{
        ArrayList liste = new ArrayList();
        liste.Add("a");
        liste.Add(1);
        liste.Add('a');
        liste.Add(true);
        Console.WriteLine(liste[2]);

        Console.WriteLine("ADD RANGE");
        int[] sayi = { 1, 2, 3 };
        List<string> renkler = new List<string>();
        renkler.Add("sari");
        renkler.Add("kırmızı");
        liste.AddRange(sayi);
        liste.AddRange(renkler);
        foreach (int i in liste)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("SORT");
        Console.ReadLine();
    }
}
