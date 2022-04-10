using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //SözDizini
            //class SınıfAdi{
                //[Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
                //[Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
            //  {
                    //Metot Komutları
            //  }    
            //}

            //Erişim Belirleyiciler
            //Public=Programın herhangi bir noktasından erişilebilir.
            //Private=Sadece tanımlandıgı sınıf içerisinden erişilebilir.
            //Internal=Sadece yazıldığı proje içinden erişilebilir.
            //Protected=Sadece tanımlandıgı sınıfta veya o sınıftan kalıtım alan sınıflardan erişilebilir.
            Calisan calisan1=new Calisan();
            calisan1.Ad="Burak";
            calisan1.Soyad="Öztürk";
            calisan1.No=012345678;
            calisan1.Departman="IT";
            calisan1.CalisanBilgileri();

            Console.WriteLine("************************");

            Calisan calisan2=new Calisan();
            calisan2.Ad="Merve";
            calisan2.Soyad="Öztürk";
            calisan2.No=876543210;
            calisan2.Departman="İnsan Kaynakları";
            calisan2.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Calisan Adi:{0}",Ad);
            Console.WriteLine("Calisan Soyadi:{0}",Soyad);
            Console.WriteLine("Calisan Numarası:{0}",No);
            Console.WriteLine("Calisan Departmanı:{0}",Departman);
        }

    }
}
