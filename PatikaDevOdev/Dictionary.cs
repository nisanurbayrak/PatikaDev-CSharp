using System;

public class Dictionary
{
	public Dictionary()
	{
		Dictionary<int, string> liste = Dictionary<int, string>();
		liste.Add(1, "a");
		liste.Add(2, "b");
		liste.Add(3, "c");

		Console.WriteLine(liste[2]);


    }
}
