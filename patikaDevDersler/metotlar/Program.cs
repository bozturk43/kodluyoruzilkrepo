using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirteci-geri donüş tipi-metod adı(parametreler){
                //metodun yapmasını istediğimizi işlemler.
            //}

            int a=5;
            int b=3;
            Console.WriteLine(a+b);
            
            Console.WriteLine("Sonuc:"+toplama(a,b));
            Metotlar obje=new Metotlar();
            obje.EkranaYazdır((a+b).ToString());
            obje.EkranaYazdır(obje.Arttırvetopla(ref a,ref b).ToString());
        }

        static int toplama(int x,int y){

            return x+y;
        }

        
        
    }

    class Metotlar{
        
        public void EkranaYazdır(string deger){
            Console.WriteLine("Ekrana Yazdır Metodundan Yazdırılan Deger:"+deger);
        }

        public int Arttırvetopla(ref int d1 , ref int d2){
            d1+=1;
            d2+=1;
            //ref anahtar kelimesi değişkenlerin adresini işaret eder böylece fonksiyon değişkenlerin kopyasını degil değişkenlerin kendisini değiştirirek bu işlemi gerçekleştirir.
            return d1+d2;
        }
    }
}
