using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme bir nesnenin bazı özelliklerini yada işlevlerini metodlarını diğer classlardan ve diğer nesnelerden korumak anlamına geliyor.
            //Bu işlem erişim belirleyiciler ile yapılır.Bir aalanı korumak istiyorsak o alanı private olarak tanımlamalıyız. Böylece baska bir classdan nesne olusturuldugunda bu alana erişilemez.
            //Ayrıca alanı dışarıya açmak istiyoruz ama bazı koşullarda kullanılmasını istersek.Bu alana bir değer atanmak istendiğinde bu değeri kontrol ederek istemediğimiz bir değerse hata fırlatmak isteyebiliriz.
            //Böyle durumlarda encapsulation kullanırız.
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Burak";
            ogrenci.Soyisim="Öztürk";
            ogrenci.OgrNo=293;
            ogrenci.Sinif=3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.Sinifdusur();
            ogrenci.Sinifdusur();
            ogrenci.Sinifdusur();
            ogrenci.Sinifdusur();

            ogrenci.OgrenciBilgileriniGetir();

            Console.ReadKey();
        }
    }

    class Ogrenci{
        private string isim;
        private string soyisim;
        private int ogrNo;
        private int sinif;

        //aşağıda farklı olarak yazdıgımız iki kod bloguda aynı işlemleri gerçekleştirmektedir.
        public string Isim 
        { 
            get {return isim;} 
            set {isim=value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif { 
            get => sinif; 
            set 
            {
                if(value<=1){
                    Console.WriteLine("Sınıf 1 den küçük olamaz");
                    sinif=1;
                }
                else{
                    sinif = value;
                }
                
            }  
        }

        //Ogrenci classının constructorını/yapıcı metodunu yazdık.
        public Ogrenci(string ısim, string soyisim, int ogrNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrNo = ogrNo;
            Sinif = sinif;
        }
        public Ogrenci(){

        }
        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("***********Ogrenci Bilgileri**********");
            Console.WriteLine("Öğrenci Adı:{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı:{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No:{0}",this.OgrNo);
            Console.WriteLine("Sınıfı:{0}",this.Sinif);
        }

        public void Sinifatlat(){
            this.Sinif=this.Sinif+1;
        }
        public void Sinifdusur(){

            this.Sinif=this.Sinif-1;
        }
    }
}
