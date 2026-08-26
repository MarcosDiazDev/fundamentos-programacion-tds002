/* 
 * Descripción: Ejercicios de variables y operadores
 * Nombre: Marcos Diaz
 * Fecha: 26/08/2026
 */

// Use el  /n para dar un salto de línea y separar la sección de menú del resto del código
Console.WriteLine("\n=== Tema 02: Variables y Operadores ===");
Console.WriteLine("1. Ficha de datos");
Console.WriteLine("2. Operadores en acción");
Console.WriteLine("3. Precedencia");
Console.Write("\nElige un ejercicio: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        FichaDeDatos();
        break;
    case "2":
        OperadoresEnAccion();
        break;
    case "3":
        Precedencia();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

// ==== Función para el ejercicio de Ficha de Datos ====
void FichaDeDatos()
{
/*
 * Nombre: Marcos Diaz
 * Fecha: 24-08-2026
 * Descripción: Este programa solicita al usuario que ingrese su nombre, edad, estatura, inicial de apellido y si es estudiante
 */

Console.WriteLine("\nIngrese su nombre: ");
//Use el console.readLine para leer la entrada del usuario
//Use el string para almacenar el nombre ingresado por el usuario en una variable tipo texto (asi con cada tipo de datos)
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
//use el .parse para convertir la entrada del usuario a un tipo de dato especifico, en este caso int para la edad
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su estatura: ");
double estatura = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su peso: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la primera inicial de su apellido: ");
char inicialApellido = char.Parse(Console.ReadLine());
Console.WriteLine("¿Eres estudiante? (Si/No): ");
bool esEstudiante = Console.ReadLine().ToLower() == "si";

// Línea final con todos los datos juntos usando $ para interpolar las cadenas y mostrar todas las variables en la consola
// Use un WriteLine vacio para darle un espacio entre la entrada de datos y la salida de datos
Console.WriteLine();
Console.WriteLine($"Nombre: {nombre} | Edad: {edad} | Estatura: {estatura}m | Peso: {peso}kg | Inicial: {inicialApellido} | Estudiante: {esEstudiante}");}


// ==== Ejercicio de Operadores en Acción ====

void OperadoresEnAccion()
{
/*
 * Nombre: Marcos Diaz
 * Fecha: 24-08-2026
 * Descripción: Este programa lee dos enteros y muestra operaciones aritméticas, relacionales y lógicas
*/

Console.WriteLine("\nIngrese el primer numero entero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero entero: ");
int num2 = int.Parse(Console.ReadLine());

// Aqui se realizan las operaciones aritméticas y se almacenan en variables
int suma = num1 + num2;
int resta = num1 - num2;
int multiplicacion = num1 * num2;
int divisionEntera = num1 / num2;
double divisionReal = (double)num1 / num2;   
int modulo = num1 % num2;

Console.WriteLine("");
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Resta: {resta}");
Console.WriteLine($"Multiplicación: {multiplicacion}");
Console.WriteLine($"División entera: {divisionEntera}");
Console.WriteLine($"División real: {divisionReal}");
Console.WriteLine($"Módulo: {modulo}");

// Comparaciones relacionales, el bool hace que el resultado sea verdadero o falso
bool mayorQue = num1 > num2;
bool igual = num1 == num2;
bool diferente = num1 != num2;

Console.WriteLine("");
Console.WriteLine($"¿num1 > num2?: {mayorQue}");
Console.WriteLine($"¿num1 == num2?: {igual}");
Console.WriteLine($"¿num1 != num2?: {diferente}");

// Operaciones lógicas, el || hace que el resultado sea verdadero si al menos una de las condiciones es verdadera, el && hace que el resultado sea verdadero solo si ambas condiciones son verdaderas 
bool ambosPositivos = num1 > 0 && num2 > 0;
bool algunoPositivo = num1 > 0 || num2 > 0;

Console.WriteLine("");
Console.WriteLine($"¿Ambos positivos?: {ambosPositivos}");
Console.WriteLine($"¿Alguno positivo?: {algunoPositivo}");
}

void Precedencia()
{
/*
* Nombre: Marcos Diaz
* Fecha: 24-08-2026
* Descripción: Este programa calcula expresiones matemáticas y explica el resultado de cada una según la precedencia de operadores
*/

Console.WriteLine("");
int resultado1 = 5 + 3 * 2;
Console.WriteLine($"5 + 3 * 2 = {resultado1}");
int resultado2 = (5 + 3) * 2;
Console.WriteLine($"(5 + 3) * 2 = {resultado2}");
int resultado3 = 10 / 4;
Console.WriteLine($"10 / 4 = {resultado3}");
double resultado4 = 10 / 4.0;
Console.WriteLine($"10 / 4.0 = {resultado4}");
int resultado5 = 10 % 4;

/*
* Explicación de resultados:
* 5 + 3 * 2 = 11      (la multiplicación tiene mayor precedencia que la suma, se calcula 3*2 primero)
* (5 + 3) * 2 = 16    (los parentesis fuerzan a sumar primero, luego se multiplica)
* 10 / 4 = 2          (division entre enteros, trunca el decimal)
* 10 / 4.0 = 2.5      (al usar 4.0 (double), la division da el resultado completo con decimales)
* 10 % 4 = 2          (el modulo da el residuo de la division, no el cociente)
*/

Console.WriteLine($"10 % 4 = {resultado5}");
}