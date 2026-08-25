/*
 *Nombre: Marcos Diaz
 *Fecha: 25-08-2026
 *Descripción: Este programa mide la distancia, consumo de combustible, precio del galón y número de pasajeros para calcular el costo total del viaje y el pago por pasajero.
 */


Console.WriteLine("\n=== Calculadora de viajes ===");
Console.WriteLine("Ingrese la distancia del viaje (km): ");
decimal distancia = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el consumo de combustible del vehículo (km por galón): ");
decimal consumo = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del galón: ");
decimal precioCombustible = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número de pasajeros: ");
int pasajeros = int.Parse(Console.ReadLine());

decimal galonesNecesarios = distancia / consumo;
decimal costoTotalCombustible = galonesNecesarios * precioCombustible;
decimal costoPorPasajero = costoTotalCombustible / pasajeros;

Console.WriteLine("\n=== Resultado del Viaje ===");
Console.WriteLine($"{"Distancia:",-25}{distancia,10} km");
Console.WriteLine($"{"Consumo:",-25}{consumo,10} km/galón");
Console.WriteLine($"{"Galones necesarios:",-25}{galonesNecesarios,10:N2}");
Console.WriteLine($"{"Precio por galón:",-25}{precioCombustible,10:C}");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"{"Costo total combustible:",-25}{costoTotalCombustible,10:C}");
Console.WriteLine($"{"Pasajeros:",-25}{pasajeros,10}");
Console.WriteLine($"{"Pago por pasajero:",-25}{costoPorPasajero,10:C}");

