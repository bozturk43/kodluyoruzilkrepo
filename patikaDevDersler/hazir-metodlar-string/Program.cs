using System;

namespace hazir_metodlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp , Hoşgeldiniz";
            string degisken2="Dersimiz CSharp";

            //Length-Degiskenin karakter sayısını verir
            Console.WriteLine(degisken.Length);
            //ToLower-ToUpper Degiskenin tüm karakterlerini büyütür ya da küçültür.
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat -degiskenleri birlestirir
            Console.WriteLine(String.Concat(degisken,"Merhaba","Burası 1 den fazla degisken alabilir"));

            //CompareTo,Compare
            Console.WriteLine(degisken.CompareTo(degisken2));//degisken -degisken 2 ye eşitse 0 return eder. degisken - degisken2 den buyukse 1 return eder.degisken-degisken2 den kücükse -1 return eder.
            Console.WriteLine(String.Compare(degisken,degisken2,true));//sondaki parametre true olursa buyuk kucuk harf duyarsız karsılastırır false olursa buyuk kucuk harf duyarlı olarak karsılastırır.

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));//degisken içinde degisken2 yi bulursa true doner bulamazsa false doner

            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));//degisken Hoigeldiniz ile bittiği için true döner.
            Console.WriteLine(degisken.StartsWith("Merhaba"));//degisken Merhaba ile baslamadıgı için false döner.

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));//degisken içinde C'yi gördüğü ilk indexi return eder. Hiç birşey bulamazsa -1 return eder.

            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i"));//i'yi buldugu son yerdeki indexi getirir.
        
            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));//0. indexten baslayarak degiskenin içine buradaki stringi ekliyor.
        
            //PadLeft,PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));//degisken2 nin sonunda 30 a tamamlayacak kadar bosluk ekledi degisken2 6 harf oldugundan 24 bosluk ekler.        
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);//degiskenin sagına karakter sayısı ile birlikte 50 tane olacak kadar bosluk ekler
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));//degiskendeki verilen indexten baslayarak kalan tüm karakterleri siler.
            Console.WriteLine(degisken.Remove(5,3));//aradan silme yapar bu önrek için 5.karakterden baslayarak 3 karakter siler.
            Console.WriteLine(degisken.Remove(0,1));//ilk karakteri siler

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));// Verilen string degeri bulup ikinci parametrede girilen deger ile degistirir.
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);//Bosluklara göre degiskeni bölüp diziye ekledi ve burada dizinin [1] elemanını biz cagırmıs olduk.

            //Substring
            Console.WriteLine(degisken.Substring(4));//degiskende 4.indexten baslayarak tüm karakterleri getirir.
            Console.WriteLine(degisken.Substring(4,6));//degiskende 4.indexten baslayıp 6 karakter getirir.


        }
    }
}
