using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
    public class Sensor_Alerta : DecoratorSensor
    {
        private readonly double _minimo;
        private readonly double _maximo;
        public Sensor_Alerta(Isensor sensor, double minimo, double maximo) : base(sensor)
        {
            _minimo = minimo;
            _maximo = maximo;
        }
        public override double LeerValor()
        {
            double valor = base.LeerValor();

            if ((valor > _maximo) && (valor > _minimo) )
            {
                Console.WriteLine($"¡ALERTA CRÍTICA! {Tipo} de: {valor}, mas alta de: {_maximo} que es el permitido");
            }
            else if ((valor < _minimo) && (valor < _maximo))
            {
                Console.WriteLine($"¡ALERTA CRÍTICA! {Tipo} de: {valor}, mas bajo de: {_minimo} que es el valor permitido");
            }
            return valor;

        }
    }

}

