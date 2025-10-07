// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");



/* Los bucles while son muy similares a los bucles do, pero tienen una diferencia importante: 
La prueba booleana en
tiene lugar al principio del ciclo del bucle, no al final. Si la prueba es falsa,
entonces el ciclo del bucle nunca se ejecuta. En su lugar, la ejecución del programa 
salta directamente al código que sigue al bucle.
 

//sintaxis

int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{i++}");
}

 Contador del 1 al 10
Muestra los números del 1 al 10 usando while.

 */
/*
int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{i++}");
}
*/
/*Contador descendente
Muestra los números del 10 al 1
 */

//int i = 10;
//while (i >=1)
//{
//    Console.WriteLine($"{i--}");

//}

//Repetir saludo
//Muestra el mensaje "Hola mundo" 5 veces.

/*
 * Repetir saludo
Muestra el mensaje "Hola mundo" 5 veces.
 */

//int i = 1;
//while (i <= 5)
//{
//    Console.WriteLine("Hola mundo");
//    i++;

//}
//Suma de números del 1 al N
//El usuario ingresa un número N, y el programa suma del 1 hasta N.
//Ejemplo: si N = 4 → resultado = 10.

//Console.WriteLine("Ingresa el numero");
//int numero  = Convert.ToInt32(Console.ReadLine());
//int suma = 0;//acumulador 
//int i = 1; //contador
//while ( i <= numero)
//{
//    suma += i;//sumamos el valor actual de i = 1
//    i++;// incrementamos i en 1

//}
//Console.WriteLine(suma);
//Mostrar números pares hasta N
//El usuario ingresa un número y el programa muestra los números pares desde 2 hasta N.

Console.WriteLine("Ingresa el numero");
int numero = Convert.ToInt32(Console.ReadLine());
int numeroPar;
int i = 1;
while (i <= numero)
{
    if (numero % 2 == 0)
    {

        i++;
    }
    Console.WriteLine($"{i}");


}
