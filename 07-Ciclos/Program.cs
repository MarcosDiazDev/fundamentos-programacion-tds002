/*
* Nombre: Marcos Diaz
* Fecha: 26-08-2026
* Descripcion :
*/

Console.WriteLine("\nEscoja una opción:");
Console.WriteLine("1. Tabla de multiplicar ");
Console.WriteLine("2. Menu que no muere");
Console.WriteLine("3. Adivina el numero");
Console.WriteLine("4. Piramide");
Console.WriteLine("5. Brake y continue");
Console.WriteLine("\nIngrese el número de la opción que desea ejecutar: ");

switch (Console.ReadLine())
{
    case "1":
        TablaMultiplicar();
        break;
    case "2":
        MenuNoMuere();
        break;
    case "3":
        AdivinaNum();
        break;
    case "4":
        Piramide();
        break;
    case "5":
        BrakeContinue();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

//Ejercicio 1
void TablaMultiplicar() 
{
/*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa lee un número e imprime su tabla de multiplicar del 1 al 12
*/

    Console.WriteLine("\nIngrese un número: ");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    // El for repite el bloque 12 veces, empezando en i=1 y aumentando de 1 en 1 hasta llegar a 12, profesor en verdad debio dejar esto con más tiempo, im tired as f**k
    for (int i = 1; i <= 12; i++)
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}

//Ejercicio 2
void MenuNoMuere()
{
/*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa muestra un menú que se repite hasta que el usuario elija Salir
*/

    string opcion;

    // El do-while ejecuta el bloque al menos una vez, y sigue repitiendo mientras la condicion sea verdadera, usted dio eso en algoritmo y ahora tambien
    do
    {
        Console.WriteLine("\n--- Menú ---");
        Console.WriteLine("1. Sumar dos números");
        Console.WriteLine("2. Ver si un número es primo");
        Console.WriteLine("3. Salir");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("\nIngrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"La suma es: {num1 + num2}");
                break;

            case "2":
                Console.WriteLine("\nIngrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                bool esPrimo = EsPrimo(numero);
                Console.WriteLine(esPrimo ? $"{numero} es primo" : $"{numero} no es primo");
                break;

            case "3":
                Console.WriteLine("\nSaliendo del menú...");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

    } while (opcion != "3");
}

// Funcion auxiliar que revisa si un numero es primo (solo divisible entre 1 y si mismo)
bool EsPrimo(int numero)
{
    if (numero < 2) return false;

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
            return false; // si encuentra un divisor exacto, no es primo
    }
    return true;
}

//Ejercicio 3
void AdivinaNum()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Juego donde el usuario adivina un número aleatorio, con contador de intentos y opción de repetir
     */

    Random random = new Random();
    string jugarDeNuevo;

    do
    {
        int numeroSecreto = random.Next(1, 101); // numero aleatorio entre 1 y 100
        int intentos = 0;
        int intento = -1; // valor inicial distinto al secreto, para entrar al while

        Console.WriteLine("\nAdivina el número (entre 1 y 100)");

        while (intento != numeroSecreto)
        {
            Console.Write("\nIngresa tu intento: ");
            intento = int.Parse(Console.ReadLine());
            intentos++;

            if (intento < numeroSecreto)
                Console.WriteLine("\nMuy bajo, intenta de nuevo.");
            else if (intento > numeroSecreto)
                Console.WriteLine("\nMuy alto, intenta de nuevo.");
            else
                Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");
        }

        Console.Write("\n¿Quieres jugar de nuevo? (Si/No): ");
        jugarDeNuevo = Console.ReadLine().ToLower();

    } while (jugarDeNuevo == "si");

    Console.WriteLine("Gracias por jugar.");
}

//Ejercicio 4
void Piramide ()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa lee una altura e imprime una pirámide de asteriscos usando ciclos anidados
     */

    Console.WriteLine("\nIngrese la altura de la pirámide: ");
    int altura = int.Parse(Console.ReadLine());

    // El ciclo controla cada fila de la piramide (de 1 hasta la altura)
    for (int fila = 1; fila <= altura; fila++)
    {
        // Ciclo interno 1: imprime los espacios en blanco para centrar la fila
        for (int espacio = 1; espacio <= altura - fila; espacio++)
        {
            Console.Write(" ");
        }

        // Ciclo interno 2: imprime los asteriscos de esa fila (siempre un numero impar creciente)
        for (int asterisco = 1; asterisco <= (2 * fila - 1); asterisco++)
        {
            Console.Write("*");
        }

        // Salto de linea para pasar a la siguiente fila
        Console.WriteLine();
    }
}

//Ejercicio 5
void BrakeContinue ()
{
/*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este programa imprime del 1 al 50 saltando los múltiplos de 3, y se detiene al llegar al primer múltiplo de 7 mayor que 30
*/

    Console.WriteLine("");

    for (int numero = 1; numero <= 50; numero++)
    {
        // Si el numero es multiplo de 3, se salta esta vuelta del ciclo sin imprimir nada
        if (numero % 3 == 0)
        {
            continue;
        }

        // Si el numero es multiplo de 7 y mayor a 30, se detiene el ciclo por completo con el break, este modulo fue divertido no cap
        if (numero % 7 == 0 && numero > 30)
        {
            break;
        }

        Console.WriteLine(numero);
    }
}