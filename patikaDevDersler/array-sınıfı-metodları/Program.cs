using System;

namespace array_sınıfı_metodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi={23,12,15,20,86,90,75,5,11,17};
            Console.WriteLine("*****SIRASIZ DİZİ*****");
            foreach (int sayi in sayidizisi)
            {
                Console.Write(sayi+",");
            }
            Console.WriteLine();

            //Sort
            Console.WriteLine("*****SIRALI DİZİ*****");
            Array.Sort(sayidizisi);
            foreach (int sayi in sayidizisi)
            {
                Console.Write(sayi+",");
            }
             Console.WriteLine();

              //Clear
            Console.WriteLine("*****CLEAR LI DİZİ*****");
            Array.Clear(sayidizisi,2,2);
            foreach (int sayi in sayidizisi)
            {
                Console.Write(sayi+",");
            }
             Console.WriteLine();

             //Revers
            Console.WriteLine("*****REVERS LI DİZİ*****");
            Array.Reverse(sayidizisi);
            foreach (int sayi in sayidizisi)
            {
                Console.Write(sayi+",");
            }
             Console.WriteLine();

             
             //Indexof
            Console.WriteLine("*****17'elemanının indexi*****");
            Console.WriteLine(Array.IndexOf(sayidizisi,17));

            //Resize
            Console.WriteLine("*****Yeniden Boyutlandırılan Dizi*****");
            Array.Resize<int>(ref sayidizisi,11);
            sayidizisi[10]=99;
            foreach (int sayi in sayidizisi)
            {
                Console.Write(sayi+",");
            }
        }
    }
}
