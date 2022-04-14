using System;

namespace static_sinif_ve_uyeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıfta o sınıfa ait static olmayan üyelere. O sınıftan bir nesne üreterek ulaşabiliyoruz.
            //Static olan elemanlara nesne olusturmaya gerek kalmadan o sınıfın adı ile erişilebilir.
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);//Calisan classı ilk olarak burada cagrıldıgı için static constructor burada 1 kere çalıştı ve program tekrar baslayasıya kadar tekrar çalışmayacak.

            Calisan calisan=new Calisan("Burak","Öztürk","IT");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);

            Calisan calisan1=new Calisan("Burak","Öztürk","IT");
            Calisan calisan2=new Calisan("Burak","Öztürk","IT");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(100,200));//Static olusturdugumuz bir sınıfın içerisindeki methodlara class ismi ile erişebiliriz örneği.
            
            //Çalışan classına baktıgımızda hem public hem static 2 constructor var.Çalışan sınıfında her nesne oluşturulduguna
            //sınıfın public olan constructor ı çalışır.
            //ancak Çalışan sınfının static constructorı çalısan sınıfına ilk erişildiğinde yalnızca 1 kere çalışır.
        }
    }



    class Calisan
    {
        //static olmayan elemanlar o sınıftan türetilen nesneye özgüdür.
        //static olan üyeler sınıfbazında atanır sınıfa aittir.
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}//çalişan sayısının set methodunu kaldırdık bu alanın dışarıdan değiştirilmesini istemiyoruz. Yalnızca class içinde değiştireceğiz.

         private string Isim;
        private string Soyisim;
        private string Departman;

        //Static bir kurucu metod olusturduk.Static kurucuların erişim belirleyicileri yoktur.
        static Calisan(){
            //static olan bir alanı burada setliycez.
            //Metodun şu işlemi yapacak.Çalışan sınıf ilk yaratıldıgında calisansayisi=0 olarak atayacak.
            calisanSayisi=0;
        }

        //Kurucu bir method yazdık
        public Calisan(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;

            calisanSayisi+=1;
        }
    }
        
        
        // Program içerisinde static bir classta oluşturabiliriz.Static bir class oluşturdugumuzda buradaki tüm alanlar ve metodlarda static olmak zorundadır.
    static class Islemler{
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
