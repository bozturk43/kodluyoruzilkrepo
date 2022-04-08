using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //<T>-> object türündedir.Buradaki T type anlamına geliyor.
            
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(27);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(32);

            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Foreach ve List.ForEach() ile elemanlara erişme.
            foreach (var item in sayiListesi)
                 Console.WriteLine(item);//Listeyi ekrana yazdırmak için kullanıyorum
            foreach (var item in renkListesi)
                 Console.WriteLine(item);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));//Listeyi ekrana yazdırmak için kullanıyorum bu yontem generic listler içinde kullanılan bir extensionmethod
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Sarı");
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));//Listeyi ekrana yazdırmak için kullanıyorum bu yontem generic listler içinde kullanılan bir extensionmethod
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            sayiListesi.RemoveAt(1);//İndexe göre eleman cıkarma.
            renkListesi.RemoveAt(0);//İndexe göre eleman cıkarma

            //Liste içerisinde arama
            if(sayiListesi.Contains(10))//Verilen elemeanı içeriyor ise true ya da false return eder
                Console.WriteLine("10 Liste İçerisinde Bulundu");
            
            //Eleman ile indexe erişme.
            renkListesi.BinarySearch("Yeşil"); //Elemanın bulundugu indexi return eder.

            //Diziyi Listeye Çevirme
            string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};
            List<string> hayvanListesi=new List<string>(hayvanlar);

            //Listeyi Temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutma.
            List<Kullanicilar> kullaniciListesi=new List<Kullanicilar>();
           
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.ad="Burak";
            kullanici1.soyad="Öztürk";
            kullanici1.yas=30;
            kullaniciListesi.Add(kullanici1);

            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.ad="Berk";
            kullanici2.soyad="Öztürk";
            kullanici2.yas=15;
            kullaniciListesi.Add(kullanici2);

            kullaniciListesi.ForEach(kullanici=>Console.WriteLine(kullanici.ad+kullanici.soyad+kullanici.yas));
            
            
        }
    }

    public class Kullanicilar{
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
    }

}
