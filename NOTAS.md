# NOTAS REPASO

**Nombre:** Marcos Diaz
**Fecha:** 25-08-2026

## `int` vs `double`

- `int`: solo números enteros, pueden ser negativos o positivos, pero sin decimales
- `double`: números con decimales
- Dividir dos `int` hace que el numero se redonde(`7 / 2 = 3`); dividir dos `double` conserva los decimales (`7.0 / 2.0 = 3.5`).
- Usar `int` para contar cosas (personas, cantidad); `double` para medidas o cálculos con decimales.

## Casting

Es convertir un valor de un tipo de dato a otro, escribiendo el tipo deseado entre paréntesis:

double numero = 9.75;
int entero = (int)numero; // entero vale 9

Se usa porque C# no mezcla tipos distintos en una operación automáticamente. Por ejemplo, para dividir dos `int` y obtener un resultado decimal, hay que convertir uno a `double` antes:

int a = 7, b = 2;
double resultado = (double)a / b; // 3.5

## Operador `%`

Devuelve el **residuo** de una división entera (no el cociente):

int residuo = 7 % 2; // residuo vale 1

Se usa para saber si un número es par/impar (`n % 2 == 0`), o para convertir unidades, como sacar los segundos sobrantes después de calcular horas y minutos

## `while` vs `for` vs `do-while`

- **`for`**: cuando sé cuántas veces se repite. `for (int i = 0; i < 5; i++) { ... }`
- **`while`**: cuando no sé cuántas veces, y puede que ni una. `while (saldo > 0) { saldo -= 100; }`
- **`do-while`**: como `while`, pero se ejecuta al menos una vez. Ideal para menús. `do { MostrarMenu(); } while (opcion != "salir");`
