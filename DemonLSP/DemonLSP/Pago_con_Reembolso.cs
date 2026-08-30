using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace DemonLSP
{
    public abstract class Pago_con_Reembolso : Metodo_de_Pago
    {

        public abstract void Reembolsar();

    }
}
