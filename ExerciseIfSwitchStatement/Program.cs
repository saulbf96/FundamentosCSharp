// See https://aka.ms/new-console-template for more information


/*
 * Pedir al usuario su edad  
eres menor de edad si es <18 
eres adulto  si esta entre 18 y 65
eres adulto mayor si  es mayor de 65 
 

//declaramos variable 
int edad;

// pedimos al usuario que ingrese su edad.
Console.WriteLine("Ingresa tu edad:");

edad = Convert.ToInt32(Console.ReadLine());// aqui asignamos lo que ingreso el usuario a edad.

//aqui evaluamos la edad y mostramos el mensaje como nos indica usare if 

if (edad < 18)
{
    //si edad es menor a 18 
    Console.WriteLine("Eres menor de edad!");
}
else if (edad >= 18 && edad <= 65)
{
    //si edad es mayor a 18 pero es igual o menor a 65 
    //aqui se usa && = AND  es verdadero si los dos cumplen con la evaluacion 
    // y || = O esto es verdadero con solo una de las dos si cumpla la evaluacion
    Console.WriteLine("eres adulto");
}
else if (edad > 65)
{
    Console.WriteLine("Eres adulto mayor");
}
*/

/*
 * Días de la semana:
El usuario ingresa un número del 1 al 7, y el programa debe mostrar el nombre del día correspondiente. Si el número no está en
ese rango, muestra "Número inválido".
 
int numero;
Console.WriteLine("Ingresa un numero para saber que dia de la semana es:");
numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("Dia de la semana es Lunes");
    break;
    case 2:
        Console.WriteLine("Dia de la semana es Martes");
        break;
    case 3:
        Console.WriteLine("Dia de la semana es Miercoles");
        break;
    case 4:
        Console.WriteLine("Dia de la semana es Jueves");
        break;
    case 5:
        Console.WriteLine("Dia de la semana es Viernes");
        break;
    case 6:
        Console.WriteLine("Dia de la semana es Sabado");
        break;
    case 7:
        Console.WriteLine("Dia de la semana es Domingo");
        break;

    default:
        Console.WriteLine($"este numero: {numero}, no pertenece a ningun numero de la semana.");
        break;
}

*/
/*
Calificaciones:
Ingresa una calificación (0 a 10) y muestra:

9 o 10 → "Excelente"

7 u 8 → "Bueno"

6 → "Suficiente"

Menos de 6 → "Reprobado" 
 */

using System.Runtime.CompilerServices;

int calificacion;
Console.WriteLine("Ingresa tu calificacion obtenida.");
calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion == 9 || calificacion == 10)
{
    Console.WriteLine($"tu calificacion {calificacion} es Excelente");
}
else if( calificacion == 7 || calificacion == 8)
{
    Console.WriteLine($"Tu calificacion es {calificacion} muy bueno");
}
else if(calificacion == 6)
{
    Console.WriteLine($"Tu calificacion {calificacion} es suficiente");
}
else if ( calificacion < 6)
{
    Console.WriteLine($"Tu calificacion es {calificacion} Reprobado");
}
else if ( calificacion is > 10)
{
    Console.WriteLine($"verifica tu calificacion {calificacion}, no es una calificacion, verifica tu numero obtenido");
}