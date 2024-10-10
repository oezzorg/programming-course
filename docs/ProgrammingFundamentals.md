# Módulo 1: Fundamentos de Programación
## 1.1 Introducción a la Programación

### Variables, tipos de datos y operadores

#### Variables: 
Una **variable** es un espacio en memoria donde podemos almacenar un valor que luego podremos modificar o utilizar en nuestro programa.

```csharp
int edad = 25;
string nombre = "Rodolfo";
bool esEstudiante = true;
```
En el ejemplo anterior podemos apreciar **3** variables que son:
- `edad` que tiene el valor `25`
- `nombre` que tiene el valor `Rodolfo`
- `esEstudiante` que tiene el valor `true`

#### Tipos de datos
En C#, como en casi todos los lenguajes de programación, tenemos varios tipos de datos que podemos usar para especificar el tipo de valor que queremos asignar a una variables, entre ellos los más comunes son:

```csharp
// 'int' o 'entero' es un tipo de dato numérico entero, es decir, sin decimales.
// Los usamos normalmente para contar cantidades o unidades. Lo utilizamos así:

int edad = 25;
int hijos = 3;
int diasDeVacaciones = 15;
int alturaEnCentimetros = 180;
```

```csharp
// 'double' o 'decimal' es un tipo de dato numérico con decimales.
// Los usamos normalmente para llevar control de datos numéricos precisos. Lo utilizamos así:

double nota = 3.5;
double kilos = 10.75;
decimal saldoEnLaCuenta = 585000.50;
decimal numeroPI = 3.141592;
```

```csharp
// 'string' es un tipo de dato que representa un texto o 'caracteres'.
// Los usamos normalmente para nombrar cosas, tales como: nombres, apellidos, direcciones, marcas, identificación, etc. Lo utilizamos así:

string nombre = "Ramiro";
string apellido = "González";
string direccion = "Calle 1 # 4 - 25 Barrio Alfonso López";
string numeroDeCedula = "10856789012";
```

```csharp
// 'bool' es un tipo de dato que representa un valor lógico, es decir, verdadero o falso.
// Los usamos normalmente para expresar una condición o para saber si se cumple o no se cumple con algo. Lo utilizamos así:

bool tieneHijos = false;
bool esMayorDeEdad = true;
bool tieneEmailVerificado = false;
bool esAdministrador = true;
```

#### Operadores
Los operadores son símbolos que nos permiten hacer **operaciones matemáticas**, **operaciones lógicas** o **comparaciones**.

```csharp
// Los operadores matemáticos son los más conocidos incluso fuera de la programación.
// Son los siguientes: +, -, *, /, %

int suma = 1 + 2;
// Resultado: 3

int resta = 2 - 1;
// Resultado: 1

int multiplicacion = 2 * 3;
// Resultado: 6

int division = 20 / 4;
// Resultado: 5

int residuo = 5 % 2;
// Resultado: 1
```

```csharp
// Los operadores lógicos son menos conocidos, se basan en Álgebra de Boole.
// Son los siguientes: &&, ||, !

// El operador 'Y' o '&&' cumple con las siguientes condiciones: Su resultado es verdadero si ambos son verdaderos.
bool operadorY = true && true;
// Resultado: true

// El operador 'O' o '||' cumple con las siguientes condiciones: Su resultado es verdadero si alguno de los dos es verdadero.
bool operadorO = true || true;
// Resultado: true

// El operador 'NO' o '!' cumple con las siguientes condiciones: Cambia entre verdadero y falso.
bool operadorNegacion = !true;
// Resultado: false;
```

```csharp
// Los comparadores sirven para tomar decisiones o saber si algo cumple o no una condición.
// Son los siguientes: ==, !=, <, >, <=, >=

// El operador 'igual' o '==' indica si dos valores son iguales.
bool operadorIgual = 1 == 1;
// Resultado: true

// El operador 'diferente' o '!=' indica si dos valores son diferentes.
bool operadorIgual = 1 != 1;
// Resultado: false

// El operador 'menor que' o '<' indica si un valor es menor a otro.
bool operadorIgual = 1 < 1;
// Resultado: false

// El operador 'mayor que' o '>' indica si un valor es mayor a otro.
bool operadorIgual = 1 > 1;
// Resultado: false

// El operador 'menor o igual que' o '<=' indica si un valor es menor o igual a otro.
bool operadorIgual = 1 <= 1;
// Resultado: true

// El operador 'mayor o igual que' o '>=' indica si un valor es mayor o igual a otro.
bool operadorIgual = 1 >= 1;
// Resultado: true
```

### Estructuras de control (if, switch, bucles)

#### Condicionales (if-else)
Permiten ejecutar un código cuando se cumple una condición, para ello nos ayudaremos de las variables **bool** y de los **operadores lógicos**.

```csharp
// Podemos usar operadores de comparación para decidir si ejecutamos o no un código
int edad = 25;

if (edad >= 18)
{
    // Es mayor de edad
}
else
{
    // Es menor de edad   
}

// También podemos usar directamente una variable de tipo bool:
bool esAdministrador = false;

if (esAdministrador)
{
    // Permitir cualquier acción
}
else
{
    // Restringir acceso
}

// Incluso podemos hacer combinaciones de variables tipo bool y operadores lógicos
bool tieneCorreoVerificado = false;

if (!tieneCorreoVerificado)
{
    // Verifique su correo antes de continuar e intente de nuevo
}
else
{
    // Permitir acceso a la página
}
```

#### Switch
Permiten seleccionar una opción entre varias opciones, es similar al 'if' pero en este caso tenemos cualquier número de opciones

```csharp
// La estructura switch permite validar si una variable tiene un valor específico:
int dia = 3;

switch (dia)
{
    case 1:
        // Lunes
        break;
    case 2:
        // Martes
        break;
    case 3:
        // Miércoles
        break;
    case 4:
        // Jueves
        break;
    case 5:
        // Viernes
        break;
    case 6:
        // Sábado
        break;
    case 7:
        // Domingo
        break;
    default:
        // Día no válido
        break;
}
```

### Funciones y procedimientos

## 1.2 Programación Orientada a Objetos (POO)
### Clases y objetos
### Encapsulamiento, herencia y polimorfismo
### Interfaces y clases abstractas
### Uso de patrones de diseño básicos