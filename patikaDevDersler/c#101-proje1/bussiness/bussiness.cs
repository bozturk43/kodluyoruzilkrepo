using System;

namespace c_101_proje1
{
    public static class Business
    {
        public static void Menu(){
            Console.WriteLine("***************TELEFON REHBERİ UYGULAMASI*************");
            Console.WriteLine("******************************************************");
            Console.WriteLine("------Menüden Bir İşlem Seçin");
            Console.WriteLine("1-)Yeni Numara Kaydetmek");
            Console.WriteLine("2-)Varolan Numarayı Silmek");
            Console.WriteLine("3-)Varolan Numarayı Güncellemek");
            Console.WriteLine("4-)Rehberi Listelemek");
            Console.WriteLine("5-)Rehberde Arama Yapmak");
            Console.WriteLine("******************************************************");            
        }
        public static void Yonlendirme(string Mesaj){

            Console.WriteLine(Mesaj+"\n"+"Ana Menüye Dönmek İçin Bir Tuşa Basın");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        
        public static int Search(string value){
            int index=0;
            index = DataContext.kisiListesi.FindIndex(x=>x.Adi.ToLower()==value.ToLower()||x.Soyadi.ToLower()==value.ToLower());
            return index;
        }
        public static void YeniKayit(){
            Console.WriteLine("Lütfen İsim Giriniz:");
            string ad=Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz:");
            string soyad=Console.ReadLine();
            Console.WriteLine("Lütfen Tel Giriniz:");
            string tel=Console.ReadLine();
            try{
                DataContext.kisiListesi.Add(new Kisi{Adi=ad,Soyadi=soyad,TelNo=tel});
            }
            catch(Exception ex){
                Yonlendirme("Beklenmedik Bir Hata Oluştu"+"Hata Detayı:"+ex.ToString());
            }
            Yonlendirme("Kisi Ekleme Basarılı");
        }
        public static void KayitSilme(){
            Console.WriteLine("Silmek İstediğiniz kisinin adını ya da soyadını girin");
            string target=Console.ReadLine();
            int index=Search(target);
            if(index!=-1){
                var kisi=DataContext.kisiListesi[index];
                Console.WriteLine(kisi.Adi+" "+kisi.Soyadi+" Kişisini Silmek İstediğinizden Eminmisiniz ?");
                Console.WriteLine("Evet için (Y) - Hayır için (N)");
                string karar=Console.ReadLine();
                if (karar=="Y")
                {
                    DataContext.kisiListesi.RemoveAt(index);    
                }
                else if(karar=="N"){
                    Yonlendirme("Silme işleminden vazgeçtiniz");
                }
                else{
                    Yonlendirme("Belirtilen Değerler Dışında Bir Giriş Yaptınız");
                }
            }

            else{
                Console.WriteLine("Kisi Bulunamadı");
                Console.WriteLine("Silmeyi Sonlandırmak İçin 1'e Basın");
                Console.WriteLine("Yeniden Denemek İçin 2'e Basın");

                string key=Console.ReadLine();
                if(key=="1"){
                    Console.Clear();
                    Menu();
                }
                else if(key=="2"){
                    KayitSilme();
                }
                else{
                    Yonlendirme("Belirtilen değerler dışında bir giriş yaptınız");
                }
            }
            
        }              
        public static void KayitGuncelle(){
            Console.WriteLine("Numarasını Güncellemek İstediğiniz Kişinin İsmini Giriniz.");
            string target=Console.ReadLine();
            int index=Search(target);
            if(index!=-1){
                var kisi=DataContext.kisiListesi[index];
                Console.WriteLine("Güncellemek İstediğiniz Kişi.");
                Console.WriteLine(kisi.Adi+" "+kisi.Soyadi+" = "+kisi.TelNo);
                Console.WriteLine("Yeni Numarayı Girin");
                string yenino=Console.ReadLine();
                DataContext.kisiListesi[index].TelNo=yenino;
                Console.Clear();
                Yonlendirme("Güncelleme İşlemi Başarılı");
            }
            else{
                Console.WriteLine("Kisi Bulunamadı");
                Console.WriteLine("Güncellemeyi Sonlandırmak İçin 1'e Basın");
                Console.WriteLine("Yeniden Denemek İçin 2'e Basın");

                string key=Console.ReadLine();
                if(key=="1"){
                    Console.Clear();
                    Menu();
                }
                else if(key=="2"){
                    KayitGuncelle();
                }
                else{
                    Yonlendirme("Belirtilen değerler dışında bir giriş yaptınız");
                }
            }
        }
        public static void KayitListele(){
            Console.Clear();
            var kisiler=DataContext.kisiListesi;
            Console.WriteLine("****************Telefon Rehberi*************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("İsim:{"+item.Adi+"}");
                Console.WriteLine("Soyisim:{"+item.Soyadi+"}");
                Console.WriteLine("Telefon Numarası:{"+item.TelNo+"}");
            }
             Console.WriteLine("****************Telefon Rehberi Sonu*************");

              Yonlendirme("Tüm rehber listelendi.");
        }
        public static void KayitArama(){
            Console.WriteLine("Aramak istediğiniz kisinin adını ya da soyadını girin");
            string target=Console.ReadLine();
            int index=Search(target);
            if(index != -1){
                Console.WriteLine("*************ARAMA SONUCUNDA BULUNAN KİŞİ***************");
                Console.WriteLine("İsim:{"+DataContext.kisiListesi[index].Adi+"}");
                Console.WriteLine("Soyisim:{"+DataContext.kisiListesi[index].Soyadi+"}");
                Console.WriteLine("Telefon Numarası:{"+DataContext.kisiListesi[index].TelNo+"}");
                Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basın");
                Console.ReadKey();
                Menu();
            }
            else{
                Console.WriteLine("Kisi Bulunamadı");
                Console.WriteLine("Aramayı Sonlandırmak İçin 1'e Basın");
                Console.WriteLine("Yeniden Denemek İçin 2'e Basın");

                string key=Console.ReadLine();
                if(key=="1"){
                    Console.Clear();
                    Menu();
                }
                else if(key=="2"){
                    KayitArama();
                }
                else{
                    Yonlendirme("Belirtilen değerler dışında bir giriş yaptınız");
                }
            }
        }
    }
}
