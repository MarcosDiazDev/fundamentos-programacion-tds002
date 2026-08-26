/*
 * Nombre: Marcos Diaz
 * Fecha: 26-08-2026
 * Descripcion: Programa que agrupa los ejercicios de modularidad (refactor, entrada blindada y sistema con ciclos)
 */

Console.WriteLine("\nEscoja una opción:");
Console.WriteLine("1. Refactor (Menú que no muere)");
Console.WriteLine("2. Entrada blindada");
Console.WriteLine("3. Sistema con ciclos");
Console.WriteLine("\nIngrese el número de la opción que desea ejecutar: ");

switch (Console.ReadLine())
{
    case "1":
        Refactor();
        break;
    case "2":
        EntradaBlindada();
        break;
    case "3":
        SistemaConCiclos();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

//Ejercicio 1: 
void Refactor()
{
    string opcion;

    do
    {
        MostrarMenu();
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                OpcionSumar();
                break;
            case "2":
                OpcionEsPrimo();
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

// Cada uno de estos metodos hace UNA sola cosa, asi el switch de arriba queda limpio y facil de leer
void MostrarMenu()
{
    Console.WriteLine("\n--- Menú ---");
    Console.WriteLine("1. Sumar dos números");
    Console.WriteLine("2. Ver si un número es primo");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
}

void OpcionSumar()
{
    int num1 = LeerEntero("Ingrese el primer número: ");
    int num2 = LeerEntero("Ingrese el segundo número: ");
    Console.WriteLine($"La suma es: {num1 + num2}");
}

void OpcionEsPrimo()
{
    int numero = LeerEntero("Ingrese un número: ");
    Console.WriteLine(EsPrimoRefactor(numero) ? $"{numero} es primo" : $"{numero} no es primo");
}

bool EsPrimoRefactor(int numero)
{
    if (numero < 2) return false;
    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}

//Ejercicio 2: 
int LeerEntero(string mensaje)
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Este metodo pide un numero entero y no deja pasar hasta que el usuario escriba uno valido
     */

    int numero;
    bool esValido;

    do
    {
        Console.Write(mensaje);
        // TryParse intenta convertir el texto a int; si falla, devuelve false en vez de tirar un error (excepcion) como hace Parse
        esValido = int.TryParse(Console.ReadLine(), out numero);

        if (!esValido)
        {
            Console.WriteLine("Entrada inválida, por favor escriba un número entero.");
        }

    } while (!esValido);

    return numero;
}

void EntradaBlindada()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Prueba del metodo LeerEntero, pide un numero y no continua hasta recibir uno valido
     */

    int numero = LeerEntero("Ingrese un número entero: ");
    Console.WriteLine($"Usted ingresó: {numero}");
}

//Ejercicio 3: 
void SistemaConCiclos()
{
    /*
     * Nombre: Marcos Diaz
     * Fecha: 26-08-2026
     * Descripción: Sistema de registro de notas con menu repetitivo, usa al menos 4 metodos
     */

    List<string> nombres = new List<string>();
    List<double> notas = new List<double>();
    string opcion;

    do
    {
        Console.WriteLine("\n--- Registro de Notas ---");
        Console.WriteLine("1. Agregar estudiante");
        Console.WriteLine("2. Ver promedio del grupo");
        Console.WriteLine("3. Ver aprobados");
        Console.WriteLine("4. Salir");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarEstudiante(nombres, notas);
                break;
            case "2":
                VerPromedio(notas);
                break;
            case "3":
                VerAprobados(nombres, notas);
                break;
            case "4":
                Console.WriteLine("\nSaliendo del sistema...");
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

    } while (opcion != "4");
}

void AgregarEstudiante(List<string> nombres, List<double> notas)
{
    Console.Write("\nNombre del estudiante: ");
    string nombre = Console.ReadLine();
    double nota = LeerNotaValida();

    nombres.Add(nombre);
    notas.Add(nota);
    Console.WriteLine("Estudiante agregado correctamente.");
}

// Metodo aparte para leer la nota con try/catch, valida que este entre 0 y 100
double LeerNotaValida()
{
    double nota = -1;
    bool esValido = false;

    do
    {
        Console.Write("Nota (0-100): ");
        try
        {
            nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 100)
            {
                esValido = true;
            }
            else
            {
                Console.WriteLine("La nota debe estar entre 0 y 100.");
            }
        }
        catch (FormatException)
        {
            // El catch atrapa el error si el usuario escribe algo que no es un numero, y el programa no se caee
            Console.WriteLine("Entrada inválida, escriba un número.");
        }

    } while (!esValido);

    return nota;
}

void VerPromedio(List<double> notas)
{
    if (notas.Count == 0)
    {
        Console.WriteLine("\nNo hay estudiantes registrados todavía.");
        return;
    }

    double suma = 0;
    foreach (double nota in notas)
    {
        suma = suma + nota;
    }

    double promedio = suma / notas.Count;
    Console.WriteLine($"\nPromedio del grupo: {promedio:F2}");
}

void VerAprobados(List<string> nombres, List<double> notas)
{
    Console.WriteLine("\nEstudiantes aprobados (nota >= 70):");
    bool hayAprobados = false;

    for (int i = 0; i < nombres.Count; i++)
    {
        if (notas[i] >= 70)
        {
            Console.WriteLine($"- {nombres[i]} ({notas[i]})");
            hayAprobados = true;
        }
    }

    if (!hayAprobados)
    {
        Console.WriteLine("Ningún estudiante aprobado por ahora.");
    }
}