using System;

namespace Romarakamlari
{
    class Program
    {
        static void Main(string[] args)
        {
        kontrol:
            try
            {
                //BURAK GÖMEÇ 2016280019
                int x;
                Console.WriteLine("Seciminizi yapin\n1-Tam sayidan=>Roma\n2-Romadan>Tam sayiya");
                switch (x = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Islemler.Romarakam();
                        break;

                    case 2:
                        Islemler.RomaYazi();
                        break;

                    default:
                        Console.WriteLine("Seciminiz taninmadi");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yanlis bir secim tusladiniz,Tekrar Deneyiniz");
                goto kontrol;
            }
            
            

        }
    }
}
