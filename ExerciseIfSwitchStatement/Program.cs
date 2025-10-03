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

/*

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
*/
/*
int operacion;
double numero1, numero2;
double resultado;
Console.WriteLine("Ingresa la oprecion que necesitas realizar");
Console.WriteLine("1.Suma");
Console.WriteLine("2.Resta");
Console.WriteLine("3.Multiplicacion");
Console.WriteLine("4.Division");


//el usuario ingresa el numero del menu
operacion = Convert.ToInt32(Console.ReadLine());
if (operacion == 1)
{
    Console.WriteLine("Elegiste suma");
}
else if (operacion == 2)
    
{
    Console.WriteLine("Elegiste Resta");
}
else if(operacion == 3)
{
    Console.WriteLine("Elegiste Multiplicacion");
}
else if (operacion == 4 )
{
    Console.WriteLine("Elegiste Division");
    
}
else
{
    Console.WriteLine("Porfavor inicia de nuevo elige un numero dentro del menu.");
}


  //pedimos al usuario que ingrese los numeros de la operacion 
Console.WriteLine("Ingresa el primer numero");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el segundo numero");
numero2 = Convert.ToDouble(Console.ReadLine());

switch (operacion)
{
    case 1:
        resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de {numero1} + {numero2} es = {resultado}");
        break;
    case 2:
        resultado = numero1 - numero2;
        Console.WriteLine($"El resultado de {numero1} - {numero2} es = {resultado}");
        break;
    case 3:
        resultado = numero1 * numero2;
        Console.WriteLine($"El resultado de {numero1} * {numero2} es = {resultado}");
        break;
    case 4:
       if (numero2 == 0)
        {
            Console.WriteLine("Error : no se puede dividir entre 0");

        }
       else
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"El resultado de {numero1} / {numero2} es = {resultado}");

        }
       break;
    default:
        break;
}
*/



