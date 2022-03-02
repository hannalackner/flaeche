using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen
{
    internal class Rechteck
    {
        private double Länge { get; set; }

        private double Breite { get; set; }

        public Rechteck(double länge, double breite)
        {
            this.Länge = länge;
            this.Breite = breite;
        }

        public double GetFläche()
        {
            double erg = Länge * Breite;
            return erg;
            //return Länge * Breite
        }

    }
}
