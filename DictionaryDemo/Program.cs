using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Category = new MyDictionary<int, string>();
            Category.Add(1, "Ayakkabı");
            Category.Add(2, "Çanta");
            Category.Add(3, "Giyim");
            Category.Add(4, "Aksesuar");
            for (int i = 0; i < Category.Keys.Length; i++)
            {
                Console.WriteLine("Kategori Id: " + Category.Keys[i] + " - " + "Kategori Adı: " + Category.Values[i]);
            }
        }
    }
}
