using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif-Özyinelemeli fonksiyonlar(kendi kendini tekrar çağıran metotlar)
            //3^4 Hesaplaması for ve rekürsif fonksiyon ile iki farklı şekilde örnek.
            int sonuc=1;
            for (int i = 1; i < 5; i++)
                sonuc=sonuc*3;
            Console.WriteLine(sonuc);

            Islemler m=new Islemler();
            Console.WriteLine(m.Exp(3,4));

            //Extension metotlar
            string ifade = "Hoist the Colours High";
            bool a=ifade.CheckSpaces();
            Console.WriteLine(a);
            if(a)
                Console.WriteLine(ifade.RemoveSpaces());
            else
                Console.WriteLine(ifade);

            Console.WriteLine(ifade.ToUpperCase());
            int[] dizi={9,4,3,5,7,6,8,2,0,1};
            foreach (int item in dizi)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            int[] siralidizi=dizi.SortArray();
            foreach (int item in siralidizi)
            {
                Console.Write(item);
            }
        }
    }

    public class Islemler{
        public int Exp(int sayi,int usdegeri){
            if(usdegeri<2)
                return sayi;

            return Exp(sayi,usdegeri-1)*sayi;
            //Metot Asağıdaki sekilde calısıyor.
            //Exp(3,4)
            //Exp(3,3) *3=>buradaki *3 return degerinden geldi.
            //Exp(3,2)*3*3
            //Exp(3,1)*3*3*3
            //3*3*3*3 son adımdaki 3 te üsdegeri 2 den kucuk oldugu için if in içinden geliyor.
            //3*4
        }
    }

    public static class Extension{
        //Extension metotlar ve classlar her zaman static olmalıdır.Nesnesi olmadan metotlara erişebilmemiz için.

        public static bool CheckSpaces(this string param){
            
            return param.Contains(" ");
        }
        public static string RemoveSpaces(this string param){
            string[] dizi=param.Split(" ");

            return string.Join("+",dizi);

        }

        public static string ToUpperCase(this string param){
            
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param){
            
            Array.Sort(param);
            return param;
        }


    }
}
