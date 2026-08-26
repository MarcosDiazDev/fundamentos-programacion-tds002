/*
* Nombre: Marcos Diaz
* Fecha: 25/08/2026
* Descripción: Programa que utiliza condicionales para ver si las aprobaste segun tu calificacones, pedir en una cafeteria y otros usos
*/

Console.WriteLine("\nIngrese un número:");
Console.WriteLine("1. Calificacion ITLA ");
Console.WriteLine("2. Menu de cafeteria");
Console.WriteLine("3. Triangulo");
Console.WriteLine("4. Par o Impar con tenario");
Console.WriteLine("5. Año bisiesto");
Console.WriteLine("\nIngrese el número de la opción que desea ejecutar: ");

switch (Console.ReadLine())
{
    case "1":
        CalificacionITLA();
        break;
    case "2":
        MenuCafeteria();
        break;
    case "3":
        Triangulo();
        break;
    case "4":
        ParImpar();
        break;
    case "5":
        AnioBisiesto();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

//Ejercicio 1
void CalificacionITLA()
{
    Console.WriteLine("\nIngrese la calificación del estudiante (0-100):");
    int calificacion = int.Parse(Console.ReadLine());

    if (calificacion < 0 || calificacion > 100)
    {
        Console.WriteLine("Calificación inválida. Debe estar entre 0 y 100.");
        return;
    }

    if (calificacion >= 90)
    {
        Console.WriteLine("\nFelicidades, has obtenido una calificación de A.");
    }
    else if (calificacion >= 80)
    {
        Console.WriteLine("\nHas obtenido una calificación de B.");
    }
    else if (calificacion >= 70)
    {
        Console.WriteLine("\nHas obtenido una calificación de C.");
    }
    else
    {
        Console.WriteLine("\nHas obtenido una calificación de F.");
    }

    if (calificacion >= 70)
    {
        Console.WriteLine("\n¡Aprobado!");
    }
    else
    {
        Console.WriteLine("\nReprobado.");
    }
}

//Ejercicio 2
void MenuCafeteria()
{
Console.WriteLine("\n=== Menú de Cafetería ===");
Console.WriteLine("1. Café - $25.00");
Console.WriteLine("2. Té - $15.00");
Console.WriteLine("3. Tostada - $50.00");
Console.WriteLine("4. Jugo natural - $50.00");
Console.WriteLine("5. Tres leches - $150.00");
Console.WriteLine("\nIngrese el número del producto que desea comprar: ");
string opcion = Console.ReadLine();

Console.WriteLine("\nSeleccione la cantidad:");
int cantidad = int.Parse(Console.ReadLine());

string producto;
double precioUnitario;

//aqui use un switch para cambiar entre las opciones dependiendo que ponga el usario
switch (opcion)
{
    case "1":
        producto = "Café(s)";
        precioUnitario = 25.00;
        break;
    case "2":
        producto = "Té(s)";
        precioUnitario = 15.00;
        break;
    case "3":
        producto = "Tostada(s)";
        precioUnitario = 50.00 ;
        break;
    case "4":
        producto = "Jugo natural(es)";
        precioUnitario = 50.00;
        break;
    case "5":
        producto = "Tres leches";
        precioUnitario = 150.00;
        break;
    default:
        Console.WriteLine("\nOPCION INVALIDA.");
        return;


}

double total = precioUnitario * cantidad;

Console.WriteLine("\n====== FACTURA ======");
Console.WriteLine($"Has seleccionado {cantidad} {producto}, ${precioUnitario:F2} c/u, total a pagar: ${total:F2}");

}

//Ejercicio 3
void Triangulo()
{
    Console.WriteLine("Ingrese el lado A");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el lado B");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el lado C");
    double c = double.Parse(Console.ReadLine());

// Aqui use varios condicionales if para saber, primero, si es un triangulo (a + b > c ) y luego que tipo de triangulo es
// Tambien use varios operadores logicos para que si las condiciones se cumplen o no digan si es o no un triangulo

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("\nLos lados SÍ forman un triángulo.");

        if (a == b && b == c)
        {
            Console.WriteLine("\nEs un triángulo equilátero.");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("\nEs un triángulo isósceles.");
        }
        else
        {
            Console.WriteLine("\nEs un triángulo escaleno.");
        }
    }
    else
    {
        Console.WriteLine("\nLos lados NO forman un triángulo.");
    }
}

//Ejercicio 4
void ParImpar()
{
    Console.WriteLine("\nIngrese un número:");
    int numero = int.Parse(Console.ReadLine());

// Aqui se hace una operacion para ver si el numero es impar o par con operadores de comparacion y una operacion matematica
    string resultado = (numero % 2 == 0) ? "par" : "impar";
    Console.WriteLine($"El número {numero} es {resultado}.");

    string signo = (numero > 0) ? "positivo" : (numero < 0) ? "\nnegativo" : "\ncero";
    Console.WriteLine($"\nEl número es {signo}.");
}

//Ejercicio 5
void AnioBisiesto()
{
    Console.WriteLine("\nIngrese un año:");
    int anio = int.Parse(Console.ReadLine());
    Console.WriteLine("");


// El boleano hace una operacion usando operadores aritmeticos y logicos para identificar si el año es bisiesto (true) o no (false)
    bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

    if (esBisiesto)
    {
        Console.WriteLine($"\n{anio} es un año bisiesto.");
                Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"\n{anio} no es un año bisiesto.");
        Console.WriteLine("");
    }
}