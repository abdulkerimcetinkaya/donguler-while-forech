using System;

namespace donguler_while_forech
{
    class Program
    {
        static void Main(String[] args)
        {
            // // 1 den başlayarak konsola girilen sayının toplamının ortalamasını alma
            // System.Console.Write("Lütfen bir sayı giriniz : ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //     toplam+= sayi;
            //     sayac ++;
            // }
            // System.Console.WriteLine(toplam / sayi);





            // // a 'dan z' ye kadar olan harfleri konsola yazdır

            // char karakter = 'a';
            // while (karakter <= 'z')
            // {
            //     System.Console.Write(karakter );
            //     karakter ++ ;
            // }


            //Forech

            String[] arabalar = {"bmw", "ford" , "Nissan"};

            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }

        
    }
}
