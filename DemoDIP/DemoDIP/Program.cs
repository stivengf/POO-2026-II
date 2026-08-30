using DemoDIP;

// ==========================
// LISTA DE OPERACIONES
// ==========================

List<Operacion> operaciones = new List<Operacion>();

Operacion suma = new Sumar(5, 50);
Operacion resta = new Restar(-625.45, 8492);
Operacion multiplicacion = new Multiplicar(5213.38, 841.25);
Operacion division = new Dividir(452, 16);

operaciones.Add(suma);
operaciones.Add(resta);
operaciones.Add(multiplicacion);
operaciones.Add(division);

/*
Se almacena una colección de tipo abstracto Operacion.

Esto permite trabajar con diferentes implementaciones sin depender de clases concretas.
Se aplica polimorfismo y el principio de inversión de dependencias.
*/


// ==========================
// EJECUCIÓN Y SALIDA
// ==========================

foreach (Operacion op in operaciones)
{
    Mostrar_Calculos mostrar = new Mostrar_Calculos(op);

    double resultado = mostrar.Mostrar_resultado();

    Console.WriteLine("Resultado: " + resultado);
}

/*
Cada operación se ejecuta a través de la abstracción Operacion.

Mostrar_Calculos no conoce el tipo concreto de operación que está ejecutando,
lo que garantiza bajo acoplamiento y cumplimiento del principio DIP.
*/