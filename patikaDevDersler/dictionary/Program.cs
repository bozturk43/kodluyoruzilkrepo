using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar=new Dictionary<int, string>();
            kullanicilar.Add(10,"Ahmet Maraz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(50,"Yılmaz Vural");

            //Dizinin elemanlarına erişim
            Console.WriteLine("******** Elemanlara Erişim ********");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(50));//True ya da False return eder
            Console.WriteLine(kullanicilar.ContainsValue("Ahmet Maraz"));//True ya da False return eder

            //Remove
            Console.WriteLine(kullanicilar.Remove(12));
        }
    }
}
