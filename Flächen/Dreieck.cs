using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen
{
    internal class Dreieck
    {
        private double Höhe { get; set; }

        private double Hypotenuse { get; set; }

        public Dreieck(double höhe, double hypotenuse)
        {
            this.Höhe = höhe;
            this.Hypotenuse = hypotenuse;
        }

        public double GetFläche()
        {
            return Höhe * Hypotenuse / 2;
        }

    }
}
