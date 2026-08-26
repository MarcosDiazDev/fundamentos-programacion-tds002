/*
 * Nombre: Marcos Diaz
 * Fecha: 26-08-2026
 * Descripcion: Programa que agrupa los ejercicios del tema de metodos (biblioteca matematica, sobrecarga, void y scope)
 */

Console.WriteLine("\nEscoja una opción:");
Console.WriteLine("1. Biblioteca matemática");
Console.WriteLine("2. Sobrecarga (Área)");
Console.WriteLine("3. Void con propósito");
Console.WriteLine("4. Scope");
Console.WriteLine("\nIngrese el número de la opción que desea ejecutar: ");

switch (Console.ReadLine())
{
    case "1":
        BibliotecaMatematica();
        break;
    case "2":
        Sobrecarga();
        break;
    case "3":
        VoidConProposito();
        break;
    case "4":
        Scope();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

//Ejercicio 1
void BibliotecaMatematica()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa prueba 4 metodos matematicos hechos por mi (sin usar Math.Pow), cada uno hace su propia logica
     */

    Console.WriteLine("\nIngrese un número para calcular su factorial: ");
    int numFactorial = int.Parse(Console.ReadLine());
    Console.WriteLine($"Factorial de {numFactorial} = {Factorial(numFactorial)}");

    Console.WriteLine("\nIngrese un número para saber si es primo: ");
    int numPrimo = int.Parse(Console.ReadLine());
    Console.WriteLine(EsPrimoMat(numPrimo) ? $"{numPrimo} es primo" : $"{numPrimo} no es primo");

    Console.WriteLine("\nIngrese dos números para calcular su MCD: ");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"MCD de {a} y {b} = {Mcd(a, b)}");

    Console.WriteLine("\nIngrese una base y un exponente para calcular la potencia: ");
    double baseNum = double.Parse(Console.ReadLine());
    int exponente = int.Parse(Console.ReadLine());
    Console.WriteLine($"{baseNum} elevado a {exponente} = {Potencia(baseNum, exponente)}");
}

// Metodo que calcula el factorial multiplicando desde 1 hasta el numero, sin usar recursividad
int Factorial(int numero)
{
    int resultado = 1;
    for (int i = 1; i <= numero; i++)
    {
        resultado = resultado * i;
    }
    return resultado;
}

// Metodo que revisa si un numero es primo, igual que hice en el tema pasado con EsPrimo
bool EsPrimoMat(int numero)
{
    if (numero < 2) return false;

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
            return false;
    }
    return true;
}

// Metodo que calcula el Maximo Comun Divisor usando el algoritmo de Euclides (dividir hasta que el residuo sea 0)
int Mcd(int a, int b)
{
    while (b != 0)
    {
        int residuo = a % b;
        a = b;
        b = residuo;
    }
    return a;
}

// Metodo que calcula una potencia multiplicando la base por si misma "exponente" veces sin usar math.pow
double Potencia(double baseNum, int exponente)
{
    double resultado = 1;
    for (int i = 1; i <= exponente; i++)
    {
        resultado = resultado * baseNum;
    }
    return resultado;
}

//Ejercicio 2
void Sobrecarga()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa prueba la sobrecarga del metodo Area, que cambia segun la cantidad de parametros que reciba
     */

    Console.WriteLine("\nIngrese el lado del cuadrado: ");
    double lado = double.Parse(Console.ReadLine());
    Console.WriteLine($"Área del cuadrado: {Calculadora.Area(lado):F2}");

    Console.WriteLine("\nIngrese base y altura del rectángulo: ");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine($"Área del rectángulo: {Calculadora.Area(b, h):F2}");

    Console.WriteLine("\nIngrese los 3 lados del triángulo: ");
    double lado1 = double.Parse(Console.ReadLine());
    double lado2 = double.Parse(Console.ReadLine());
    double lado3 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Área del triángulo: {Calculadora.Area(lado1, lado2, lado3):F2}");
}

//Ejercicio 3
void VoidConProposito()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa usa 2 metodos void para enmarcar un titulo, uno llama al otro dentro de si mismo
     */

    Console.WriteLine("\nIngrese el título que quiere enmarcar: ");
    string titulo = Console.ReadLine();

    ImprimirTitulo(titulo);
}

// Metodo void que imprime una linea repitiendo un caracter "n" veces, no devuelve nada, solo imprime
void ImprimirLinea(char c, int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(c);
    }
    Console.WriteLine();
}

// Metodo void que usa ImprimirLinea para armar un marco alrededor del titulo
void ImprimirTitulo(string t)
{
    ImprimirLinea('=', t.Length + 4);
    Console.WriteLine($"  {t}");
    ImprimirLinea('=', t.Length + 4);
}

//Ejercicio 4
void Scope()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa demuestra que una variable declarada dentro de un metodo no se puede ver ni usar fuera de el (en Main)
     */

    // Esta variable "mensajeInterno" solo existe DENTRO de este metodo Scope(), su "alcance" (scope) es limitado a estas llaves { }
    string mensajeInterno = "Esta variable solo vive aqui dentro";
    Console.WriteLine(mensajeInterno);

    // Si intentara usar "mensajeInterno" en el Main (arriba, en el switch) o en otro metodo como BibliotecaMatematica(),
    // el compilador daria error porque esa variable ya no existe fuera de estas llaves
    // esto pasa porque cada metodo tiene su propio "espacio" de memoria para sus variables locales,
    // y ese espacio se borra apenas el metodo termina de ejecutarse
}

// Sobrecarga 1: recibe 1 parametro, calcula area de cuadrado (lado al cuadrado)
// Sobrecarga 2: recibe 2 parametros, calcula area de rectangulo (base por altura)
// Sobrecarga 3: recibe 3 parametros, calcula area de triangulo con la formula de Heron
// Tuve que meter estos 3 metodos en una clase aparte porque no permiten sobrecarga, o sea no dejan tener 2 metodos con el mismo nombre aunque tengan distinta cantidad de parametros, dentro de una clase si funciona normal
static class Calculadora
{
    public static double Area(double lado)
    {
        return lado * lado;
    }

    public static double Area(double b, double h)
    {
        return b * h;
    }

    public static double Area(double a, double b, double c)
    {
        // El semiperimetro es la mitad de la suma de los 3 lados
        double semiperimetro = (a + b + c) / 2;
        return Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c));
    }
}