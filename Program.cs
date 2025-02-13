﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_osztalyokGittel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv harryPotter = new Konyv("Harry Potter és a Bölcsek Köve", "J.K. Rowling", 1997, 320, 4500);
            Console.WriteLine(harryPotter.ToString());

            Film harryPotterFilm = new Film("Harry Potter és a Bölcsek Köve", "Chris Columbus", 152, "Fantasy", true);
            Console.WriteLine(harryPotterFilm);

            Karakter karakter1 = new Karakter("Harry", 5, 120, 50);
            Console.WriteLine(karakter1);

            Urhajo urhajo1 = new Urhajo("Apollo 11", 120, 3, 80);
            Console.WriteLine(urhajo1);

            Kem kem1 = new Kem("007","Anglia",12,74);
            Console.WriteLine(kem1);

            Console.ReadKey();
        }
    }
}
