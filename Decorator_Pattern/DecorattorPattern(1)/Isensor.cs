using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
    public interface Isensor
    {
        public string Tipo { get; }
        public double LeerValor();
    }
}
