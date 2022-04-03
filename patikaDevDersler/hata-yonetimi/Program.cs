using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           /* try
            {
                Console.WriteLine("Bir Sayı Gir!");
                int sayi=Convert.ToInt32(Console.ReadLine());
    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                
            }
            finally
            {
                Console.WriteLine("İslem tamamlandı");

            }*/
            try
            {
                //int a=int.Parse(null);//ArgumentNullException
                //int a =int.Parse("test");//FormatException
                int a=int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Deger Gridiniz" + ex);
            }            
            catch (FormatException ex)
            {
                Console.WriteLine("Format Hatası" + ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Değer Sınırları Aşıldı"+ex);
            }
            
        }
    }
}
