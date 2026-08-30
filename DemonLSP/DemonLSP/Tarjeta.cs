using System;
using System.Collections.Generic;
using System.Text;

namespace DemonLSP
{
    public class Tarjeta : Pago_con_Reembolso
    {
        public Tarjeta(string nombre, double monto)
        {
            this.nombre = nombre;
            this.monto = monto;

        }
        public override void procesarpago()
        {
            Console.WriteLine($"Nombre: {this.nombre} Monto pagado: {this.monto}");
        }

        public override void Reembolsar()
        {
            Console.WriteLine($"Nombre: {this.nombre} Monto reembolsado: {this.monto}");
        }
    }
}
