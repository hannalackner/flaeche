using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen;

internal class Quadrat
{
    private double Seite { get; set; }

    public Quadrat(double seite)
    {
        this.Seite = seite;
        
    }

    public double GetFläche()
    {
        return Seite * Seite;
    }

}
