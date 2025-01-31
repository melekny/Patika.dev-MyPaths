﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //Elemanlara Erişim
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange(Birden fazla eleman ekleme)
            Console.WriteLine("**********AddRange*************");
            string[] liste1 = { "kırmızı", "sarı", "yesil" };
            List<int> sayilar = new List<int> { 1, 8, 4, 7, 9, 0, 5 };
            liste.AddRange(liste1);
            liste.AddRange(sayilar);
            ArrayList sayilarListesi = new ArrayList();
            sayilarListesi.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("***** Sort ******");
            liste.Sort();
            //Farklı tipte degerleri olan bir listede derleme zamanında hata vermez ancak çalışma zamanında hata verir.

            //BinarySearch
            Console.WriteLine("******Binary Search*******");
            sayilarListesi.Sort();//Binary Search kullanmadan önce diziyi sıralamamız gerekli.
            Console.WriteLine(sayilarListesi.BinarySearch(9));
            foreach (var item in sayilarListesi)
            {
                Console.Write(item);
            }

            //Reverse
            Console.WriteLine("******Reverse*******");
            sayilarListesi.Reverse();
            foreach (var item in sayilarListesi)
                Console.WriteLine(item);
            //Clear
            liste.Clear();

        }
    }
}