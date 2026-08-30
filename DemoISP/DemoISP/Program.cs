using DemoISP;

// 
// INSTANCIAS
// 

IOp_basic calcSimple = new Calc_Simple();
IOps_Basic calcBasica = new Calc_basica();
IOps_cientificas calcCientifica = new Calc_Cietific();

/*
Cada variable usa la interfaz más adecuada según sus capacidades.

- calcSimple → solo suma
- calcBasica → operaciones básicas
- calcCientifica → todas las operaciones

Esto demuestra ISP: cada cliente usa solo lo que necesita
*/


// 
// USO DE OPERACIONES
// 

// Calculadora simple
Console.WriteLine(calcSimple.Sumar(5, 10));

/*
calcSimple SOLO conoce Sumar.
No puede acceder a Restar, Multiplicar, etc.
→ No se le obliga a usar métodos innecesarios (ISP)
*/


// Calculadora básica
Console.WriteLine(calcBasica.Sumar(10, 5));
Console.WriteLine(calcBasica.Restar(10, 5));
Console.WriteLine(calcBasica.Multiplicar(10, 5));
Console.WriteLine(calcBasica.Dividir(10, 5));

/*
calcBasica tiene acceso a operaciones básicas,
pero no a operaciones científicas.

→ No ve métodos que no necesita (ISP)
*/


// Calculadora científica
Console.WriteLine(calcCientifica.Sumar(2, 3));
Console.WriteLine(calcCientifica.Potencia(2, 3));
Console.WriteLine(calcCientifica.Logaritmo(8, 2));

/*
calcCientifica implementa todas las interfaces necesarias,
ya que sí requiere todas las operaciones.

→ Se agregan capacidades sin afectar a otras clases (ISP)
*/


// 
// PRUEBA DE CONTRATOS
// 

IOp_basic prueba = new Calc_Cietific();
Console.WriteLine(prueba.Sumar(100, 200));

/*
Una calculadora científica puede usarse como una simple,
pero solo expondrá el método Sumar.

→ Se respeta la segregación de interfaces
→ Se usa el contrato adecuado según el contexto
*/