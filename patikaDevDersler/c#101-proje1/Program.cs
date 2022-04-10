using System;

namespace c_101_proje1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DataContext.kisiListesi.Add(new Kisi{Adi="Burak",Soyadi="Öztürk",TelNo="+905426356897"});
            DataContext.kisiListesi.Add(new Kisi{Adi="Berk",Soyadi="Öztürk",TelNo="+905326357897"});
            while(true){
                Console.Clear();
            Business.Menu();
            string secim=Console.ReadLine();
            switch(secim){
                case "1":
                    Business.YeniKayit();
                    break;
                case "2":
                    Business.KayitSilme();
                    break;
                case"3":
                    Business.KayitGuncelle();
                    break;
                case"4":
                    Business.KayitListele();
                    break;
                case"5":
                    Business.KayitArama();
                    break;
            }
            }
            
           
        }
    }
}
