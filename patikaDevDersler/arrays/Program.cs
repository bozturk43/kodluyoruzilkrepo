using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler=new string[5];

            string[] hayvanlar ={"Kedi","Köpek","Kuş","Maymun"};
            
            int[] dizi;
            dizi =new int[5];

            //Dizilere değer atama ve erişim.
            renkler[0]="Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle Diziler
            Console.WriteLine("Dizi Boyutunu Girin");
            int diziboyutu=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[diziboyutu];
            int ortalama=0;
            int toplam=0;
            for (int i = 0; i < diziboyutu; i++)
            {
                Console.WriteLine(i+". elemanı girin");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in array)
            {
                toplam+=item;
            }
            ortalama=toplam/diziboyutu;
            Console.WriteLine(ortalama);
        }
    }
}
