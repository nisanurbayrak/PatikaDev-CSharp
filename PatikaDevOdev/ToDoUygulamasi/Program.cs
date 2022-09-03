using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Kart Ekle\r\n2)Kart Güncelle\r\n3)Kart Sil\r\n4)Board Listeleme");
            string secim = Console.ReadLine();
            List<string> ToDoList = new List<string>();
            TodoL todol = new TodoL();
            
            switch (secim)
            {
                case "1":
                    Console.Write("Başlık: ");
                    todol.Baslik = Console.ReadLine();
                    Console.Write("İçerik: ");
                    todol.Icerik = Console.ReadLine(); 
                    Console.Write("Atanan Kişi: ");
                    todol.AtananKisi = Console.ReadLine(); 
                    Console.Write("Büyüklük (XS, S, M, L, XL): ");
                    todol.Buyukluk = Console.ReadLine().ToUpper();
                    ToDoList.Add(todol.Baslik);
                    ToDoList.Add(todol.Icerik);
                    ToDoList.Add(todol.AtananKisi);
                    ToDoList.Add(todol.Buyukluk);
                    break;

                    case "2":
                    Console.Write("Güncellemek istediğiniz başlığı giriniz: ");
                    string GuncellenecekAd = Console.ReadLine();
                    int count = 0;
                    foreach (var item in ToDoList)
                    {
                        if (item.Contains(GuncellenecekAd))
                        {
                            Console.Write("Başlık: ");
                            todol.Baslik = Console.ReadLine();
                            Console.Write("İçerik: ");
                            todol.Icerik = Console.ReadLine();
                            Console.Write("Atanan Kişi: ");
                            todol.AtananKisi = Console.ReadLine();
                            Console.Write("Büyüklük (XS, S, M, L, XL): ");
                            todol.Buyukluk = Console.ReadLine().ToUpper();
                            ToDoList.Add(todol.Baslik);
                            ToDoList.Add(todol.Icerik);
                            ToDoList.Add(todol.AtananKisi);
                            ToDoList.Add(todol.Buyukluk);
                            Console.WriteLine("Güncelleme başarılı.");
                        }
                        else
                        {
                            count++;
                            continue;
                        }
                    }
                    if (count == ToDoList.Count)
                    {
                        Console.WriteLine("Kayıt bulunamadı.");
                    }
                    break;

                case "3":
                    Console.Write("Silmek istediğiniz başlık: ");
                    string SilinecekBaslik = Console.ReadLine();
                    foreach (var item in ToDoList)
                    {
                        if (item.Contains(SilinecekBaslik))
                        {
                            ToDoList.Remove(todol.Baslik);
                            ToDoList.Remove(todol.Icerik);
                            ToDoList.Remove(todol.AtananKisi);
                            ToDoList.Remove(todol.Buyukluk);
                        }
                        
                    }
                    break;
                    case "4":
                    foreach (var item in ToDoList)
                    {
                        Console.WriteLine("List");
                        Console.WriteLine(item);
                    }
                    break;

            }
        }
        class TodoL
        {
            public string Baslik { get; set; }
            public string Icerik { get; set; }
            public string AtananKisi { get; set; }
            public string Buyukluk { get; set; }
        }
    }
}
