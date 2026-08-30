using System;
using System.Collections.Generic;
using System.Text;

namespace DemonLSP
{
    public class Efectivo : Metodo_de_Pago
    {
        public Efectivo(string nombre, double monto)
        {
            this.nombre = nombre;
            this.monto = monto;
        }
        public override void procesarpago()
        {
            Console.WriteLine($"Nombre: {this.nombre} Monto pagado: {this.monto}");
        }
    }
}
