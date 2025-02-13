using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_osztalyokGittel
{
    internal class Karakter
    {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public Karakter(string nev, int szint, int eletero, int ero) 
        {
           this.nev = nev;
           this.szint = szint;
           this.eletero = eletero;
           this.ero = ero;
        }

        public Karakter(string nev,int ero)
        {
            this.nev = nev;
            this.szint = 1;
            this.eletero = 100;
            this.ero = ero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => Szint; set => Szint = value; }
        public int Eletero { get => Eletero; set => Eletero = value; }
        public int Ero { get => Ero; set => Ero = value; }

        public void Tamadas()
        {
            Console.WriteLine($"Támadás! Ekkora erővel: {this.ero}");
        }

        public void Gyogyulas(int mennyiseg)
        {
            this.eletero += mennyiseg;
        }

        public void Szintlepes()
        {
            this.szint++;
            this.ero++;
        }

        public override string ToString()
        {
            return $"Név: {this.nev}, Szint: {this.szint}, Életerő: {this.eletero}, Erő: {this.ero}";
        }


    }
}
