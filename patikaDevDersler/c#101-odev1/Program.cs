using System;
using System.Collections.Generic;

namespace c_101_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odevler o=new Odevler();
            o.Odev1();
            o.Odev2();
            o.Odev3();
            o.Odev4();
            
        }
    }

    public class Odevler{
        Metotlar metotlar =new Metotlar();
        public void Odev1(){
            Console.WriteLine("************************ÇALIŞAN PROGRAM ODEV 1************************");
            Console.WriteLine("Pozitiif Bir Sayı Girin");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n.SayıPozitifmi()){
                Console.WriteLine("Negatif ya da Sıfır Girdiniz Program Başa Dönüyor");
                Odev1();
            }
            var dizi=metotlar.DiziOlustur(n);
            foreach (var item in dizi)
            {
                if(item%2==0){
                    Console.WriteLine("Girdiğiniz Sayılardan Çift Olan:");
                    Console.WriteLine(item);
                }
                    
            }
        }

        public void Odev2(){
            Console.WriteLine("************************ÇALIŞAN PROGRAM ODEV 2************************");
            Console.WriteLine("Pozitiif Bir Sayı Girin");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pozitiif Bir Sayı Girin");
            int m=Convert.ToInt32(Console.ReadLine());
            if(n.SayıPozitifmi() && m.SayıPozitifmi()){
                Console.WriteLine("Negatif ya da Sıfır Girdiniz Program Başa Dönüyor");
                Odev2();
            }
            var dizi=metotlar.DiziOlustur(n);
            foreach (var item in dizi)
            {
                if(item==m || item%2==0){
                    Console.WriteLine("m'e Eşit veya İkiye Bölünen Sayı:");
                    Console.WriteLine(item);
                }       
            }
        }

        public void Odev3(){
            Console.WriteLine("************************ÇALIŞAN PROGRAM ODEV 3************************");
            Console.WriteLine("Pozitiif Bir Sayı Girin");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n.SayıPozitifmi()){
                Console.WriteLine("Negatif ya da Sıfır Girdiniz Program Başa Dönüyor");
                Odev3();
            }
            var dizi=metotlar.StrDiziOlustur(n);
            dizi.Reverse();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            

        }

        public void Odev4(){
            Console.WriteLine("************************ÇALIŞAN PROGRAM ODEV 4************************");
            Console.WriteLine("Bir cümle girin");
            string cumle=Console.ReadLine();
            string[] dizi=cumle.Split(" ");
            string bosluksuz=string.Join("",dizi);
            char[] chardizi=bosluksuz.ToCharArray();
            Console.WriteLine("Cümle "+dizi.Length+" kelimeden oluşuyor");
            Console.WriteLine("Cümle "+chardizi.Length+" harften oluşuyor");
            
        }
    }
    public class Metotlar{
        List<int> array=new List<int>();
        List<string> arraystr=new List<string>();
        //Recursive olarak diziye eleman ekleme
        public List<int> DiziOlustur(int n){
            if(n==0)
                return array;
            Console.WriteLine("Bir Sayı Girin");    
            array.Add(Convert.ToInt32(Console.ReadLine()));
            return DiziOlustur(n-1);
        }
        public List<string> StrDiziOlustur(int n){
            if(n==0)
                return arraystr;
            Console.WriteLine("Bir Kelime Girin ve Daha Sonra Entera Basın");    
            arraystr.Add(Console.ReadLine());
            return StrDiziOlustur(n-1);
        }

    }
    public static class Extensionmetodlar{

        //Sayının negatif ya da o oldugunu kontrol eden extension metod
        public static bool SayıPozitifmi(this int n){
            if(n<0||n==0)
                return true;
            return false;
        }
    }
}
