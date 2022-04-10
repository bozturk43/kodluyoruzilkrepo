using System;
using System.Collections;

namespace c_101_odev2_soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalListesi=new ArrayList();
            ArrayList asalolmayanListesi=new ArrayList();

            for(int i=0;i<=20;i++){
                Console.WriteLine(i+".Sayıyı Girin");
                try{
                    int sayi=Convert.ToInt32(Console.ReadLine());
                    if(sayi<0){
                        Console.WriteLine("Negatif Olmayan Bir Sayi Girin");
                    }
                    else{
                        if(asalmı(sayi)==true){
                            asalListesi.Add(sayi);
                        }
                        else{
                            asalolmayanListesi.Add(sayi);
                        }
                    }
                }
                catch(Exception ex){
                    Console.WriteLine("Hata Oluştu"+ex.ToString());
                }
                
            }

            int toplam1=0;
            int toplam2=0;
            asalListesi.Sort();
            asalolmayanListesi.Sort();
            asalListesi.Reverse();
            asalolmayanListesi.Reverse();
            
            foreach (int item in asalListesi)
            {
                toplam1+=item;
            }
             foreach (int item in asalolmayanListesi)
            {
                toplam2+=item;
            }

            Console.WriteLine("Asal Sayı Adedi:"+asalListesi.Count);
            Console.WriteLine("Asal Sayı Ortalaması:"+toplam1/asalListesi.Count);
            Console.WriteLine("Asal Olmayan Sayı Adedi:"+asalolmayanListesi.Count);
            Console.WriteLine("Asal Olmayan Sayı Ortalaması:"+toplam2/asalolmayanListesi.Count);
            Console.ReadKey();

        }
          static bool asalmı(int sayi){
            int sayac=0;
            if(sayi==1||sayi==0){
                return true;
            }
            else{
                
                for(int i=1;i<=sayi;i++){
                    if(sayi%i==0){
                        sayac++;
                    }
                }
                if(sayac==2){
                    return true;
                }
                else{
                    return false;
                }
            
            }
        }
        
      
    }
}
