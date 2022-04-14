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
            
            Calisan calisan1=new Calisan("Burak","Öztürk",012345678,"IT");
            calisan1.CalisanBilgileri();

            Console.WriteLine("************************");

            Calisan calisan2=new Calisan("Merve","Öztürk",876543210,"İnsan Kaynakları");
            calisan2.CalisanBilgileri();

            Console.WriteLine("************************");
            
            Calisan calisan3=new Calisan("Bera","Öztürk");
            calisan3.CalisanBilgileri();

            Console.ReadKey();
            //Kurucu metodlar bi sınıfın nesnesi oluşturuldugunda arka planda otomatik olarak calıstırılan metodlardır. Bunlar kurucu metodlar/yapıcı metodlar/constructor lar olarak adlandırılır.
            //Kurucu metodlar tanımlanırken isimleri sınıf isimleri ile aynı olmak zorundadır.Erişim belirleyicileri mutlaka public olmak zorundadır.
            //Kurucu metodların geri dönüş tipleri bulunmaz.Geri döndürmeyen metodlarda olduğu gibi void burada yazılmaz.Metod yalnızca erişim belirleyici+ class ile aynı isimde olur.
            //Kurucu metodlar overload edilebilir.

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        // classın Kurucu metodu
        public Calisan(string ad , string soyad, int no, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        //Kurucu metodu overload ediyoruz
        public Calisan(string ad , string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){

        }

        public void CalisanBilgileri(){
            Console.WriteLine("Calisan Adi:{0}",Ad);
            Console.WriteLine("Calisan Soyadi:{0}",Soyad);
            Console.WriteLine("Calisan Numarası:{0}",No);
            Console.WriteLine("Calisan Departmanı:{0}",Departman);
        }

    }
}
