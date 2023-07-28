using System;

namespace patik_odev{
    class Program{
        static void Main(string[] args){
           Console.WriteLine("kaç tane kelime girmek istiyorsunuz: ");
              int sayi = Convert.ToInt32(Console.ReadLine());
              string[] kelimeler = new string[sayi];
                for(int i = 0; i < sayi; i++)
                {
                    Console.WriteLine( (i+1) +". kenimenizi giriniz: ");
                    kelimeler[i] = Console.ReadLine();
                }
                Console.WriteLine("TERSTEN KELİMELERİM:");
                foreach( string kelimelerim in kelimeler.Reverse())
                {
                        Console.Write(kelimelerim + " ");
                }
           Console.ReadLine();
        }
    }
}