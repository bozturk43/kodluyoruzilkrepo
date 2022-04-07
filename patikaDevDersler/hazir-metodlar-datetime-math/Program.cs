using System;

namespace hazir_metodlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.Write(DateTime.Now.DayOfWeek);//Haftanın gününü string olarak verir.
            Console.Write(DateTime.Now.DayOfYear);//bulundugumuz günün 360 gün içinden kacıncı gün oldugunu verir.
            Console.Write(DateTime.Now.ToLongDateString());//  Gün,Ay Ayın günü,Yıl
            Console.Write(DateTime.Now.ToShortDateString());// Gün/Ay/Yıl

            Console.Write(DateTime.Now.ToLongTimeString());//Saat:Dakika:Saniye
            Console.Write(DateTime.Now.ToShortTimeString());//Saat:Dakika

            Console.Write(DateTime.Now.AddDays(2));//Bulundugumuz güne gün ekler
            Console.Write(DateTime.Now.AddHours(3));//Bulundugumuz saate saat ekler
            Console.Write(DateTime.Now.AddSeconds(4));//Bulundugumuz dakikaya dakika ekler
            Console.Write(DateTime.Now.AddMonths(2));//Bulundugumuz aya ay ekler
            Console.Write(DateTime.Now.AddMonths(6));//Bulundugumuz aya  ay ekler
            Console.Write(DateTime.Now.AddYears(10));//Bulundugumuz yıla yıl ekler
            
            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//07
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Bulundugu gunun 3 harfini getirir(Saturda için Sat)
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Bulundugu gunun tamamını getirir.

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Bulundugu ayın ilk 3 harfini getirir(April için Apr)
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Bulundugu ayın tamamını getirir(April)

            Console.WriteLine(DateTime.Now.ToString("YY"));//22
            Console.WriteLine(DateTime.Now.ToString("YYYY"));//2022

            //Math

            Console.WriteLine(Math.Abs(-15));//Mutlak Deger
            Console.WriteLine(Math.Sin(30));//Verilen Sayının sin karsılıgını verir.
            Console.WriteLine(Math.Cos(30));//Verilen Sayının cos karsılıgını verir.
            Console.WriteLine(Math.Tan(30));//Verilen Sayının tan karsılıgını verir.

            Console.WriteLine(Math.Ceiling(10.55f));//Double Üzerine çalışır 10.55 ten buyuk en kucuk tam sayıyı getirir.
            Console.WriteLine(Math.Round(10.55));//En yakına yuvarlar 11
            Console.WriteLine(Math.Floor(10.55));//Aşağı yuvarlar 10 

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(3,9));

            Console.WriteLine(Math.Pow(3,4)); //Üs Alma 3^4
            Console.WriteLine(Math.Sqrt(9)); // Sayının karekökü
            Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3));//e^3 ü verir.
            Console.WriteLine(Math.Log10(10));//10 sayısının logaritma 10 tabanındaki karşılığını verir.






        }
    }
}
