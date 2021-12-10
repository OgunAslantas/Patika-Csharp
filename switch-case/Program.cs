﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
             int month = DateTime.Now.Month;

            //Expression
            //switch case ile bulunan ayı göster
            switch(month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındayız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındayız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındayız");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındayız");   
                    break;  
                default:
                    Console.WriteLine("Lütfen 1 ile 12 arasında bir sayı giriniz"); 
                    break;                       
            }


           //switch case ile bulunan mevsimi göster

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Bahar ayındasınız.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız.");
                    break;
            }  
        }
    }
}
