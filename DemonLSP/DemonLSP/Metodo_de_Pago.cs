using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemonLSP
{
    public abstract class Metodo_de_Pago
    {
        public double monto;
        public string nombre;
        public abstract void procesarpago();

    }
}
