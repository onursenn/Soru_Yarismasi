using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_Yarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soru = 1;
            char cevap;
            sbyte puan = 0;

            if (soru == 1)
            {
                Console.WriteLine("Aşağıdakilerden Hangisi Asya Kıtasındadır? ");
                Console.WriteLine("A-Madagaskar B-Singapur C-Peru");
                Console.Write("Cevabı Girin: ");
                cevap = Convert.ToChar(Console.ReadLine());
                if (cevap=='b'| cevap == 'B')
                {

                    Console.WriteLine("Doğru Cevap");
                    soru = soru + 1;
                    puan = puan += 25;
                }
                else
                {
                    Console.WriteLine("Yanlış Cevap");
                }
            }
            if (soru == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Aşağıdakilerden Hangisi Kuvvet Birimidir?");
                Console.WriteLine("A-Joule B-Newton C-Pascal");
                Console.Write("Cevabı Girin: ");
                cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'b' | cevap == 'B')
                {
                    Console.WriteLine("Doğru Cevap");
                    soru = soru + 1;
                    puan = puan += 25;
                }
                else
                {
                    Console.WriteLine("Yanlış Cevap"+" "+"Toplam Puanınız:"+ puan);
                }
            }
            if (soru == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Fas'ın Başkenti Hangisidir?");
                Console.WriteLine("A-Kahire B-Kazablanka C-Rabat");
                Console.Write("Cevabı Girin: ");
                cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'c' | cevap == 'C')
                {
                    Console.WriteLine("Doğru Cevap");
                    soru = soru + 1;
                    puan = puan += 25;
                }
                else
                {
                    Console.WriteLine("Yanlış Cevap" + " " + "Toplam Puanınız:" + puan);
                }
            }
            if (soru == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Sinekli Bakkal Romanının Yazarı Hangisidir?");
                Console.WriteLine("A-Halide Edip Adıvar B-Ömer Seyfettin C-Ziya Gökalp");
                Console.Write("Cevabı Girin: ");
                cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'a' | cevap == 'A')
                {
                    puan = puan += 25;
                    Console.WriteLine("Doğru Cevap Tebrikler Tüm Soruları Doğru Bildiniz. "+"Puanınız: "+puan);
                  
                }
                else
                {
                    Console.WriteLine("Yanlış Cevap" + " " + "Toplam Puanınız:" + puan);
                }
            }
            
            Console.Read();
        }
    }
}
