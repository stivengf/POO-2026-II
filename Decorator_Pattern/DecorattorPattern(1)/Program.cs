using EJEMPLO2;

Console.WriteLine("=== SISTEMA DE MONITOREO DE SENSORES ===\n");

Console.WriteLine("--- Sensor de Temperatura ---");

Isensor tempBase = new Sensor_T();
Isensor tempCelsius = new SensorCelsius(tempBase);
Isensor tempConAlerta =new Sensor_Alerta(tempCelsius, minimo: 15, maximo: 25);

Console.WriteLine($"Tipo: {tempConAlerta.Tipo}");
double valorTemp = tempConAlerta.LeerValor();
Console.WriteLine($"Valor: {valorTemp} °C");


Console.WriteLine("\n-------------------------------------\n");
Console.WriteLine("--- Sensor de Humedad ---");

Isensor humedadBase = new Sensor_H();
Isensor humedadConAlerta = new Sensor_Alerta(humedadBase, minimo: 30, maximo: 70);
Console.WriteLine($"Tipo: {humedadConAlerta.Tipo}");
double valorHumedad = humedadConAlerta.LeerValor();
Console.WriteLine($"Valor: {valorHumedad} %");

