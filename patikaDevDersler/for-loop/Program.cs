using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int length=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }

            }
            */

            /*
            int tektoplam=0;
            int cifttoplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==0){
                    cifttoplam+=i;
                }
                else{
                    tektoplam+=i;
                }
            }
            Console.WriteLine("Tek Toplam="+tektoplam);
            Console.WriteLine("Cift Toplam="+cifttoplam);
            */

            //Break Continue

            for (int i = 1; i <= 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i.ToString());
            }
            for (int i = 1; i <= 10; i++)
            {
                if (i==4)   
                {
                    continue; //yalnızca bu kosul gerceklestiginde ifin icerisine girer ve daha sonra loop u sonlandırır ama sonlandırmaması için continue yazarsak if içindeki kodu okuyup tekrar loop a devam eder.
                }
                Console.WriteLine(i.ToString());
            }

        }
    }
}
