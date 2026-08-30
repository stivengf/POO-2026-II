using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoDIP
{
    public class Mostrar_Calculos
    {
        public Operacion operacion;
        public Mostrar_Calculos(Operacion operacion)
        {
            this.operacion = operacion;
        }
        public double Mostrar_resultado() => this.operacion.ejecutar();
    }
}
