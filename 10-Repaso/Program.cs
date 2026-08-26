/* 
 * Nombre: Marcos Diaz
 * Fecha: 25-08-2026
 * Descripción: Simulador de cajero automático. Valida PIN 
 * y luego permite consultar saldo, depositar, retirar (validando fondos y
 * múltiplos de 100) o salir. Saldo inicial: RD$10,000.
 */

const int PIN_CORRECTO = 1234;
const int MAX_INTENTOS = 3;
decimal saldo = 10000m;

if (ValidarPin())
{
    Menu();
}
else
{
    Console.WriteLine("\nHa superado el número máximo de intentos. Tarjeta bloqueada.");
}

// ===== Métodos =====

bool ValidarPin()
{
    for (int intento = 1; intento <= MAX_INTENTOS; intento++)
    {
        Console.Write($"Ingrese su PIN (intento {intento} de {MAX_INTENTOS}): ");
        int pinIngresado = int.Parse(Console.ReadLine());

        if (pinIngresado == PIN_CORRECTO)
        {
            Console.WriteLine("PIN correcto.\n");
            return true;
        }

        Console.WriteLine("PIN incorrecto.\n");
    }

    return false;
}

void Menu()
{
    bool salir = false;

    while (!salir)
    {
        Console.WriteLine("=== Cajero Automático ===");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Retirar");
        Console.WriteLine("4. Salir");
        Console.Write("Elija una opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ConsultarSaldo();
                break;
            case "2":
                Depositar();
                break;
            case "3":
                Retirar();
                break;
            case "4":
                salir = true;
                Console.WriteLine("\nGracias por usar el cajero. ¡Hasta luego!");
                break;
            default:
                Console.WriteLine("\nOpción inválida.\n");
                break;
        }
    }
}

void ConsultarSaldo()
{
    Console.WriteLine($"\nSaldo actual: {saldo:C}\n");
}

void Depositar()
{
    Console.Write("\nIngrese el monto a depositar (múltiplo de 100): ");
    decimal monto = decimal.Parse(Console.ReadLine());

    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor que cero.\n");
        return;
    }

    if (monto % 100 != 0)
    {
        Console.WriteLine("El monto debe ser múltiplo de 100.\n");
        return;
    }

    saldo += monto;
    Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo:C}\n");
}

void Retirar()
{
    Console.Write("\nIngrese el monto a retirar (múltiplo de 100): ");
    decimal monto = decimal.Parse(Console.ReadLine());

    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor que cero.\n");
        return;
    }

    if (monto % 100 != 0)
    {
        Console.WriteLine("El monto debe ser múltiplo de 100.\n");
        return;
    }

    if (monto > saldo)
    {
        Console.WriteLine("Fondos insuficientes.\n");
        return;
    }

    saldo -= monto;
    Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo:C}\n");
}
