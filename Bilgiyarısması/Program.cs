using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Bilgiyarısması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazar[] yazarlar = new Yazar[5];

            Yazar y1 = new Yazar();
            y1.isim = "Jack Londan";
            y1.eser = "Martin Eden";
            y1.millet = "Amerikalı";
            y1.tür = "Macera";
            yazarlar[0] = y1;

            Yazar y2 = new Yazar();
            y2.isim = "Fyodor Dostoyevski";
            y2.eser = "Öteki";
            y2.millet = "Rus";
            y2.tür = "Psikolojik";
            yazarlar[1] = y2;

            Yazar y3 = new Yazar();
            y3.isim = "Bram Stoker";
            y3.eser = "Dracula";
            y3.millet = "İrlandalı";
            y3.tür = "Korku";
            yazarlar[2] = y3;

            Yazar y4 = new Yazar();
            y4.isim = "Jules Verne";
            y4.eser = "Dünya'nın Merkezine Yolculuk";
            y4.millet = "Fransız";
            y4.tür = "Bilim Kurgu";
            yazarlar[3] = y4;

            Yazar y5 = new Yazar();
            y5.isim = "Arthur Conan Doyle";
            y5.eser = "Sherlock Holmes'un Maceraları";
            y5.millet = "İngiliz";
            y5.tür = "Dedektif";
            yazarlar[4] = y5;

            Padisah[] padisahlar = new Padisah[5];

            Padisah p1 = new Padisah();
            p1.isim = "2.Abdülhamid";
            p1.sıra = 34;
            p1.yıl = 33;
            p1.meslek = "Marangozluk";
            padisahlar[0] = p1;

            Padisah p2 = new Padisah();
            p2.isim = "4.Murat";
            p2.sıra = 17;
            p2.yıl = 17;
            p2.meslek = "Hattatlık";
            padisahlar[1] = p2;

            Padisah p3 = new Padisah();
            p3.isim = "Kanuni Sultan Süleyman";
            p3.sıra = 10;
            p3.yıl = 46;
            p3.meslek = "Kuyumculuk";
            padisahlar[2] = p3;

            Padisah p4 = new Padisah();
            p4.isim = "Yavuz Sultan Selim";
            p4.sıra = 9;
            p4.yıl = 8;
            p4.meslek = "Kuyumculuk";
            padisahlar[3] = p4;

            Padisah p5 = new Padisah();
            p5.isim = "Fatih Sultan Mehmet";
            p5.sıra = 7;
            p5.yıl = 30;
            p5.meslek = "Bahçıvanlık";
            padisahlar[4] = p5;

            int toplam =0;
            int ds = 0;
            int ys = 0;
            int bos = 0;

           
            Console.WriteLine("Bilgi Yarışmasına Hoş Geldin Arkadaşım ☻\n");
            Console.WriteLine("Bilgi Yarışması ile İlgili Bilinmesi Gerekenler:\n");           
            Console.WriteLine("1. Her Doğru Cevap 10 Puandır. \n2. Her Yanlış Cevap -5 Puandır. \n3. Pas İse 0 Puandır.");
            Console.WriteLine("4. Cevap Vermek İçin a,b,c,d,e veya f Tuşuna Basman Ayrıca Cevabı Görmek ve Bir Sonraki Soruya Geçmek İçin Entera Basman Yeterli. ");
            Console.WriteLine("5. Eğer 'Ek Soru İstiyorum.' Seçeneğini Seçersen: Yeni Bir Ek Soru Gelir Ama Ek Soruda Pas Geçme Şansın Yoktur.");
            Console.WriteLine("   Yani Ya + Puan Alacaksın ya da - Puan Alacaksın. Risk Almayı Seviyorsan Dene Derim ;)\n");
           

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Hazır Hissettiğinde Enter'a Bas Canım ♥ Haa Bu Arada Unutmadan Başarılar Dilerim ☻");
            Console.ReadLine();

            SoundPlayer player = new SoundPlayer();
            string ses;
            ses = "eveny-gringo.wav";
            player.SoundLocation = ses;
            player.Play();

            Console.ForegroundColor = ConsoleColor.Magenta;
                
            Console.WriteLine("1)Bram Stoker'ın Kült Eseri Aşağıdakilerden hangisidir?\n ");

            Console.WriteLine($"  A){yazarlar[1].eser}\n  B){yazarlar[2].eser}\n  C){yazarlar[3].eser}\n  D){yazarlar[0].eser}\n  E)Ek soru istiyorum\n  F)Pas\n");

            Console.Write("  Cevap: ");
            string c1 = Console.ReadLine();
            Console.WriteLine("");


            if (c1 == "b") 
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c1 == "f")
            {
                bos++;
            }
            else if(c1 == "e")
            {
                Console.WriteLine("  Ek Soru: Dünya'nın Merkezine Yolculuk Adlı Eser Hangi Yazarındır?\n ");
                Console.WriteLine($"  A){yazarlar[1].isim}\n  B){yazarlar[2].isim}\n  C){yazarlar[3].isim}\n  D){yazarlar[4].isim}\n");
                Console.Write("  Cevap: ");
                string e1 = Console.ReadLine();
                Console.WriteLine("");

                if (e1 == "c")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : Jules Verne \n");
                    toplam -= 5;
                    ys++;
                }
            }

            else 
            {
                Console.WriteLine("  Doğru Cevap : Dracula \n");
                toplam -= 5;
                ys++;
            }

            Console.ReadLine();

            Console.ForegroundColor= ConsoleColor.Cyan;

            Console.WriteLine("2)Mesleği Marangozluk Olan Padişah Kimdir?\n");
            Console.WriteLine($"  A) {padisahlar[0].isim}\n  B) {padisahlar[2].isim}\n  C) {padisahlar[3].isim}\n  D) {padisahlar[4].isim}\n  E) Ek soru istiyorum\n  F) Pas\n");

            Console.Write("  Cevap: ");
            string c2 = Console.ReadLine();
            Console.WriteLine("");

            if (c2 == "a")
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c2 == "f")
            {
                bos++;
            }
            else if (c2 == "e")
            {
                Console.WriteLine("  Ek Soru: Kanuni Sultan Süleyman'ın Padişahlık Süresi Aşağıdakilerden Hangisidir?\n");
                Console.WriteLine($"  A){padisahlar[1].yıl}\n  B){padisahlar[4].yıl}\n  C){padisahlar[3].yıl}\n  D){padisahlar[2].yıl}\n");

                Console.Write("  Cevap: ");
                string e2 = Console.ReadLine();
                Console.WriteLine("");

                if (e2 == "d")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : 46 \n");
                    toplam -= 5;
                    ys++;
                }
  
            }
            else
            {
                Console.WriteLine("  Doğru Cevap : 2.Abdülhamid \n");
                toplam -= 5;
                ys++;
            }

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("3)Jules Verne'nin Uyruğu Nedir?\n ");
            Console.WriteLine($"  A){yazarlar[1].millet}\n  B){yazarlar[2].millet}\n  C){yazarlar[3].millet}\n  D){yazarlar[4].millet}\n  E)Ek soru istiyorum\n  F)Pas\n");


            Console.Write("  Cevap: ");
            string c3 = Console.ReadLine();
            Console.WriteLine("");

            if (c3 == "c")
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c3 == "f")
            {
                bos++;
            }
            else if (c3 == "e")
            {
                Console.WriteLine("  Ek Soru: Fyodor Dostoyevski'nin Eserleri Hangi Türdür?\n");
                Console.WriteLine($"  A){yazarlar[1].tür}\n  B){yazarlar[2].tür}\n  C){yazarlar[3].tür}\n  D){yazarlar[4].tür}\n");

                Console.Write("  Cevap: ");
                string e3 = Console.ReadLine();
                Console.WriteLine("");

                if (e3 == "a")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : Psikolojik \n");
                    toplam -= 5;
                    ys++;
                }

            }
               
            else
            {
                Console.WriteLine("  Doğru Cevap : Fransız \n");
                toplam -= 5;
                ys++;
            }
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("4) 17.Osmanlı Padişahı Kimdir?\n");
            Console.WriteLine($"  A) {padisahlar[0].isim}\n  B) {padisahlar[2].isim}\n  C) {padisahlar[1].isim}\n  D) {padisahlar[4].isim}\n  E) Ek soru istiyorum\n  F) Pas\n");


            Console.Write("  Cevap: ");
            string c4 = Console.ReadLine();
            Console.WriteLine("");

            if (c4 == "c")
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c4 == "f")
            {
                bos++;
            }
            else if (c4 == "e")
            {
                Console.WriteLine("  Ek Soru: Bahçıvanlık Yapan Padişah Aşağıdakilerden Hangisidir?\n");
                Console.WriteLine($"  A){padisahlar[1].isim}\n  B){padisahlar[2].isim}\n  C){padisahlar[3].isim}\n  D){padisahlar[4].isim}\n");

                Console.Write("  Cevap: ");
                string e4 = Console.ReadLine();
                Console.WriteLine("");

                if (e4 == "d")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : Fatih Sultan Mehmet \n");
                    toplam -= 5;
                    ys++;
                }

            }
            else
            {
                Console.WriteLine("  Doğru Cevap : 4. Murat \n");
                toplam -= 5;
                ys++;
            }
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("5)Öteki Adlı Eser Kime Aittir?\n ");
            Console.WriteLine($"  A){yazarlar[1].isim}\n  B){yazarlar[2].isim}\n  C){yazarlar[3].isim}\n  D){yazarlar[0].isim}\n  E)Ek soru istiyorum\n  F)Pas\n");

            Console.Write("  Cevap: ");
            string c5 = Console.ReadLine();
            Console.WriteLine("");

            if (c5 == "a")
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c5 == "f")
            {
                bos++;
            }
            else if (c5 == "e")
            {
                Console.WriteLine("  Ek Soru: Jack London'ın Eserleri Hangi Türdür?\n");
                Console.WriteLine($"  A){yazarlar[1].tür}\n  B){yazarlar[0].tür}\n  C){yazarlar[3].tür}\n  D){yazarlar[4].tür}\n");

                Console.Write("  Cevap: ");
                string e5 = Console.ReadLine();
                Console.WriteLine("");

                if (e5 == "b")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : Macera \n");
                    toplam -= 5;
                    ys++;
                }
            }
            else
            {
                Console.WriteLine("  Doğru Cevap : Fyodor Dostoyevski \n");
                toplam -= 5;
                ys++;
            }

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;


            Console.WriteLine("6) 2.Abdülhamid Kaçıncı Padişahtır?\n");
            Console.WriteLine($"  A) {padisahlar[1].sıra}\n  B) {padisahlar[2].sıra}\n  C) {padisahlar[3].sıra}\n  D) {padisahlar[0].sıra}\n  E) Ek soru istiyorum\n  F) Pas\n");

            Console.Write("  Cevap: ");
            string c6 = Console.ReadLine();
            Console.WriteLine("");

            if (c6 == "d")
            {
                Console.WriteLine("  Tebrikleeer ☻\n");
                toplam += 10;
                ds++;
            }
            else if (c6 == "f")
            {
                bos++;
            }

            else if (c6 == "e")
            {
                Console.WriteLine("  Ek Soru: Yavuz Sultan Selim Kaç Yıl Hüküm Sürmüştür?\n");
                Console.WriteLine($"  A){padisahlar[1].yıl}\n  B){padisahlar[2].yıl}\n  C){padisahlar[3].yıl}\n  D){padisahlar[4].yıl}\n");

                Console.Write("  Cevap: ");
                string e6 = Console.ReadLine();
                Console.WriteLine("");

                if (e6 == "c")
                {
                    Console.WriteLine("  Tebrikleeer ☻\n");
                    toplam += 10;
                    ds++;
                }
                else
                {
                    Console.WriteLine("  Doğru Cevap : 8 \n");
                    toplam -= 5;
                    ys++;
                }

            }
            else
            {
                Console.WriteLine("  Doğru Cevap : 34. Padişah \n");
                toplam -= 5;
                ys++;
            }
            Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.White;

            player.Stop();
            Console.ReadLine() ;

            Console.WriteLine("  Toplam puan : " + toplam);
            Console.WriteLine("  Doğru Sayısı : " + ds);
            Console.WriteLine("  Yanlış Sayısı : " + ys);
            Console.WriteLine("  Boş Sayısı : " + bos);        
            Console.ReadLine();


            SoundPlayer play = new SoundPlayer();
            string s;
            s = "conguratilation.wav";
            player.SoundLocation = s;
            player.Play();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
           
            Console.WriteLine("  Yarışmanın Sonuna Geldik Umarım Eğlenmişsindir Kendine İyi Bak Tekrar Görüşmek Dileğiyle ☺\n");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;




        }


    }
}
