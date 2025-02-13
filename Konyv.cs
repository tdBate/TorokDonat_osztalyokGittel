using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_osztalyokGittel
{
    internal class Konyv
    {
        private string cim;
        private string szerzo;
        private int kiadasEve;
        private int oldalSzam;
        private double ar;

        public Konyv(string cim, string szerzo, int kiadasEve, int oldalSzam, double ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = kiadasEve;
            this.oldalSzam = oldalSzam;
            this.ar = ar;
        }

        public Konyv (string cim, string szerzo)
        {
            this.cim= cim;
            this.szerzo = szerzo;
            this.kiadasEve = DateTime.Now.Year;
            this.oldalSzam = 200;
            this.ar = 3000;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
        public int OldalSzam { get => oldalSzam; set => oldalSzam = value; }
        public double Ar { get => ar; set => ar = value; }

        public void Arnoveles(int osszeg) 
        {
            this.ar += osszeg;
        }

        public void Kedvezmeny(double szazalek)
        {
            this.ar*=(100-szazalek)/100;
        }

        public int HanyOldalMaradt(int elolvasott)
        {
            return this.oldalSzam-elolvasott;
        }

        public override string ToString()
        {
            return $"Cím: {this.cim}, Szerző: {this.szerzo}, Kiadás éve: {this.kiadasEve}, Oldalszám: {this.oldalSzam}, Ár: {this.ar} Ft";
        }
    }
}
