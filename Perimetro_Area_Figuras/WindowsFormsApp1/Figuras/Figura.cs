using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Figuras
{
    public abstract class Figura
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
