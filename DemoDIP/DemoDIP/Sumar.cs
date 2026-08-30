using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDIP
{
    public class Sumar : Operacion
    {
        public double n1;
        public double n2;
        public Sumar(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public override double ejecutar() => this.n1 + this.n2;

    }
}
