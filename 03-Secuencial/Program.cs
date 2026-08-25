/*
 * Nombre: Marcos Diaz
 * Fecha: 25/08/2026
 * Descripción:
 */

Console.WriteLine("\n=== Tema 03: Programas secuenciales ===");
Console.WriteLine("1. Conversor de temperatura");
Console.WriteLine("2. Area y perímetro");
Console.WriteLine("3. Cambio de moneda");
Console.WriteLine("4. Saludo personalizado");
Console.Write("\nElige un ejercicio: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        ConversorDeTemperatura();
        break;
    case "2":
        AreaYPerimetro();
        break;
    case "3":
        CambioDeMoneda();
        break;
    case "4":
        SaludoPersonalizado();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

void ConversorDeTemperatura()
{
/*
* Nombre: Marcos Diaz
* Fecha: 24-08-2026
* Descripción: Este programa convierte una temperatura en grados Celsius a Fahrenheit y Kelvin
*/


Console.WriteLine("\nIngrese la temperatura en grados Celsius: ");
double celsius = double.Parse(Console.ReadLine());

//Formulas de conversion, use el Math.Round para redondear los resultados a 2 decimales 
double fahrenheit = Math.Round((celsius * 9 / 5) + 32, 2);
double kelvin = Math.Round(celsius + 273.15, 2);

Console.WriteLine("");
Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F");
Console.WriteLine($"{celsius}°C equivale a {kelvin}K");
Console.WriteLine("");
}



void AreaYPerimetro()
{
/*
* Nombre: Marcos Diaz
* Fecha: 24-08-2026
* Descripción: Este programa calcula el área y perímetro de un círculo y de un rectángulo
*/

Console.WriteLine("\nIngrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());

// Area del circulo: PI * radio^2, use el Math.PI para obtener el valor de PI y Math.Pow para elevar al cuadrado
double areaCirculo = Math.PI * Math.Pow(radio, 2);

// Perimetro (circunferencia) del circulo: 2 * PI * radio, aqui tambien use el Math.PI para obtener el valor de PI
double perimetroCirculo = 2 * Math.PI * radio;

Console.WriteLine("");
Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
Console.WriteLine($"Perímetro del círculo: {perimetroCirculo:F2}");

Console.WriteLine("\nIngrese el largo del rectángulo: ");
double largo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el ancho del rectángulo: ");
double ancho = double.Parse(Console.ReadLine());
double areaRectangulo = largo * ancho;
double perimetroRectangulo = 2 * (largo + ancho);

Console.WriteLine("");
Console.WriteLine($"Área del rectángulo: {areaRectangulo:F2}");
Console.WriteLine($"Perímetro del rectángulo: {perimetroRectangulo:F2}");
Console.WriteLine("");
}

void CambioDeMoneda()
{
/*
     * Nombre: Marcos Diaz
     * Fecha: 24-08-2026
     * Descripción: Este programa convierte un monto en pesos dominicanos a dólares y euros según las tasas ingresadas
     */

Console.WriteLine("\nIngrese el monto en pesos dominicanos: ");
double pesos = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la tasa de cambio a dólares: ");
double tasaDolar = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la tasa de cambio a euros: ");
double tasaEuro = double.Parse(Console.ReadLine());

//El monto en pesos se dvide entre la tasa de cambio para obtener el monto en dólares y euros, use el Math.Round para redondear los resultados a 2 decimales
double dolares = Math.Round(pesos / tasaDolar, 2);
double euros = Math.Round(pesos / tasaEuro, 2);

Console.WriteLine("");
Console.WriteLine($"{pesos} pesos dominicanos equivale a {dolares} dólares");
Console.WriteLine($"{pesos} pesos dominicanos equivale a {euros} euros");
Console.WriteLine("");
}


void SaludoPersonalizado()
{
/*
* Nombre: Marcos Diaz
* Fecha: 24-08-2026
* Descripción: Este programa saluda a un usuario por su nombre
*/

Console.WriteLine("\nIngrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido: ");
string apellido = Console.ReadLine();

// Concatene nombre y apellido, y use ToUpper para que todo sea mayuscula
string nombreCompleto = (nombre + " " + apellido).ToUpper();

// Use Length porque cuenta la cantidad de caracteres del string (incluye el espacio entre nombre y apellido)
int cantidadLetras = nombreCompleto.Length;

// Use Substring(inicio, cantidad) extrae una parte del texto; aqui tomamos solo el primer caracter de cada palabra
string inicialNombre = nombre.Substring(0, 1).ToUpper();
string inicialApellido = apellido.Substring(0, 1).ToUpper();

Console.WriteLine("");
Console.WriteLine($"Nombre completo: {nombreCompleto}");
Console.WriteLine($"Cantidad de letras: {cantidadLetras}");
Console.WriteLine($"Iniciales: {inicialNombre}.{inicialApellido}.");
Console.WriteLine("");
}
