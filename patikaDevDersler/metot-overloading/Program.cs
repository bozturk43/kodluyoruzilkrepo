using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out genellikle try parse metodu ile kullanılıyor.Fonksiyona iş yaptırdıktan sonra setlenen değeri kullanmak istiyorsak bunu out parametre ile döndürüyoruz.
            //örnekler.
            string sayi="999";
            
            bool sonuc=int.TryParse(sayi,out int outSayi);

            if(sonuc==true)
                Console.WriteLine("Basarılı"+outSayi);
            else
                Console.WriteLine("Basarısız");
            Metotlar m=new Metotlar();
            m.Topla(150,450,out int sonuc1);
            Console.WriteLine("Out Parametreden Gelen Sonuc:"+sonuc1);
            //Metot overloading fonksiyonun imzasını değiştirierek birden farklı şekilde kullanabilmek demektir.
            int sayi1=999;
            
            m.EkranaYazdır(sayi1);//Normalde bu adda yalnızca string veri alan bir metot için int değişkeni parametre olarak gönderemezdik ancak aynı metot adı ile int parametre alan bir metot daha olusturduk.Bu duruma EkranaYazdır metodunu overload etmek deniyor.
            m.EkranaYazdır(sayi1.ToString());

            //Bu iki durumda hangi metodu çağıracağına metot imzasına göre karar veriyor.
            //Metot İmzası=metotadi+parametre sayisi+parametre
            m.EkranaYazdır("Merhaba","Overload");
            //Aynı metotu iki parametre alacak sekilde aynı isimle yazdık.
        }
    }
    class Metotlar
    {
        public void Topla(int a ,int b,out int toplam)
        {
            toplam=a+b;

        }
        //Overloading örneği
        public void EkranaYazdır(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri){
            Console.WriteLine(veri);
        }
        
        public void EkranaYazdır(string veri1,string veri2){
            Console.WriteLine(veri1+veri2);
        }
        
    }
}
