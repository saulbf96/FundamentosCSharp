// See https://aka.ms/new-console-template for more information

/*
 Pedir al usuario su edad  
eres menor de edad si es <18 
eres adulto  si esta entre 18 y 65
eres adulto mayor si  es mayor de 65 
 */

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
