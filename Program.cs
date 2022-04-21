using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("emre");
            liste.Add(20);
            liste.Add(false);
            liste.Add('B');

            // içerisindeki verilere erişim 

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            
            // addrange (arrayliste dizi dizi yada list ekleme )
            Console.WriteLine("************addrange************"); 
            List<int> sayılar = new List<int>{3,2,5,4,6,7};
            string[] hayvanlar = {"maymun","bukalemun","orangutan","tırtıl"};

            liste.AddRange(sayılar);
            liste.AddRange(hayvanlar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            // reverse       (arraylisti diziyi yada listeyi ayna görünümüyle ters çevirir yada küçükten büyüğe olan bir diziyi büyükten küçüğe şeklinde sıralar diyebiliriz.)

            Console.WriteLine("*********Reverse************");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear  (liste nin içerisini sıfırlar - siler)

            liste.Clear();


        }
    }
}