using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Romarakamlari
{
    class Islemler
    {
        public static void Romarakam()
        {
            int sayac = 2;
            int[] ucbasamak = new int[2]; //3 basamakli sayilar icin dizi
            int[] dortbasamak = new int[3];//4 basamakli sayilar icin dizi
            string[] birler = {"","I", "II", "III", "IV", "V", "VI", "VII", "VIII","IX"};
            string[] onlar = {"","X","XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] yuzler = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM" };
            string[] binler = {"","M","MM","MMM" };
            int a = 0;
            Console.WriteLine("Sayiyi giriniz");
            int x = int.Parse(Console.ReadLine());
            if(x>0 && x <4000)
            {
                a = x / 10;
            kontrol:
                if (a > 10)
                {
                    dortbasamak[2] = a % 10;
                    ucbasamak[1] = a % 10;
                    a = a / 10;
                    sayac++;
                    ucbasamak[0] = a;
                    if (a > 10)
                    {
                        dortbasamak[1] = a % 10;
                        a = a / 10;
                        dortbasamak[0] = a;
                        sayac++;
                    }
                    goto kontrol;
                }
                else
                {
                    if (sayac <= 2) //1-2 basamak
                    {
                        Console.WriteLine(onlar[a % 10] + birler[x % 10]);
                    }
                    else if (sayac <= 3 && sayac > 2) //3 basamak
                    {
                        Console.WriteLine(yuzler[ucbasamak[0]] + onlar[ucbasamak[1]] + birler[x % 10]);
                    }
                    else if (sayac == 4) //4 basamak
                    {
                        Console.WriteLine(binler[dortbasamak[0]] + yuzler[dortbasamak[1]] + onlar[dortbasamak[2]] + birler[x % 10]);
                    }
                }
            }
            else { Console.WriteLine("Sayi formatini dogru giriniz--1 ile 3999 arasi--"); }
        }

        public static void RomaYazi()
        {
            int[] onluk = new int[4];
            string[] birler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] onlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] yuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] binler = { "", "M", "MM", "MMM" };
            Console.WriteLine("Roma rakamini giriniz");
            string x = Console.ReadLine();
            string yeni;
            yeni = x.ToUpper();
            char[] ayrilmis = x.ToCharArray();
            for(int i = 0; i < ayrilmis.Length; i++)
            {
                if(ayrilmis[i]=='1' || ayrilmis[i] == '2' || ayrilmis[i] == '3' || ayrilmis[i] == '4' ||
                    ayrilmis[i] == '5' || ayrilmis[i] == '6' || ayrilmis[i] == '7' || ayrilmis[i] == '8' ||
                    ayrilmis[i] == '9' || ayrilmis[i] == '0')
                {
                    Console.WriteLine("Roma harfinin formatini dogru giriniz.Örnek:XI");
                    break;
                }
                else
                {
                    goto kontrol2;
                }
            }
           
        kontrol2:
            Hashtable liste = new Hashtable();

            liste.Add("I", "1");

            liste.Add("II", "2");

            liste.Add("III", "3");

            liste.Add("IV", "4");

            liste.Add("V", "5");

            liste.Add("VI", "6");

            liste.Add("VII", "7");

            liste.Add("VIII", "8");

            liste.Add("IX", "9");

            liste.Add("X", "10");

            liste.Add("XX", "20");

            liste.Add("XXX", "30");

            liste.Add("XL", "40");

            liste.Add("L", "50");

            liste.Add("LX", "60");

            liste.Add("LXX", "70");

            liste.Add("LXXX", "80");

            liste.Add("XC", "90");

            liste.Add("C", "100");

            liste.Add("CC", "200");

            liste.Add("CCC", "300");

            liste.Add("CD", "400");

            liste.Add("D", "500");

            liste.Add("DC", "600");

            liste.Add("DCC", "700");

            liste.Add("DCCC", "800");

            liste.Add("CM", "900");

            liste.Add("M", "1000");

            string bol = x.ToUpper();

            int sayi = 0;

            for (int i = 0; i < bol.Length; i++)
            {
                if (bol.Length - i == 2)
                {
                    string data = bol[i].ToString() + bol[i + 1].ToString();

                    if (data == "IX" || data == "XL" || data == "CD" || data == "CM" || data == "XC")
                    {
                        sayi = int.Parse(liste[data].ToString()) + sayi;

                        i++;
                    }
                    else
                    {
                        sayi = int.Parse(liste[bol[i].ToString()].ToString()) + sayi;
                    }
                }
                else
                {
                    sayi = int.Parse(liste[bol[i].ToString()].ToString()) + sayi;
                }
            }
            Console.WriteLine(sayi);
        }

    }
}
