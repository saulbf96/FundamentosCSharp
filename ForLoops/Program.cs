// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 Este tipo de bucle ejecuta un número determinado de veces y mantiene su propio contador. 
 Para definir un bucle for, necesitas la siguiente información:

1.Un valor inicial para inicializar la variable contador
2. Una condición para continuar el bucle, en la que interviene la variable contador.
3. Una operación a realizar sobre la variable contador al final de cada ciclo de bucle

Por ejemplo, si desea un bucle con un contador que se incremente de 1 a 10 en pasos de uno, entonces el
valor inicial es 1; la condición es que el contador sea menor o igual que 10; y la operación a realizar 
al final de cada ciclo es sumar 1 al contador.
realizar al final de cada ciclo es sumar 1 al contador.
 */
//sintaxis
/*
 for (<initialization>; <condition>; <operation>)
{
 <code to loop>
}
 */
//Escribir los numero del 1 al 10;

/*
 * La variable contador, un entero llamado i, comienza con un valor de 1 y se incrementa 
 * en 1 al final de cada ciclo. Durante cada ciclo, el valor de i se escribe en la consola
 * 
 * 
A veces se desea un control más preciso del procesamiento del código en bucle. 
C# proporciona comandos para ayudarle en este caso:

1. break-Causa que el bucle termine inmediatamente

2. continue-Causa que el ciclo de bucle actual termine inmediatamente 
(la ejecución continúa con la tecla 
siguiente ciclo de bucle)
3. return-Salta del bucle y de su función contenedora.
 */
/*
int i;
for (i = 1; i <= 10; ++i)
{
    Console.WriteLine($"{i}");
}
*/

/*
 * 
 * 
El comando break simplemente sale del bucle, y la ejecución continúa en la primera 
línea de código después del comando 
como se muestra en el siguiente ejemplo:

*****
Este código escribe los números del 1 al 5 porque el comando break provoca la salida del bucle 
cuando i llega a 6.

int i = 1;
while (i <= 10)
{
 if (i == 6)
 break;
 Console.WriteLine($"{i++}");
}

**************************************
*
*
continue sólo detiene el ciclo actual, no todo el bucle, como se muestra aquí:
En el ejemplo anterior, siempre que el resto de i dividido por 2 sea cero, la sentencia continue
detiene la ejecución del ciclo actual, por lo que sólo se muestran los números 1, 3, 5, 7 y 9.
int i;
for (i = 1; i <= 10; i++)
{
 if ((i % 2) == 0)
 continue;
 Console.WriteLine(i);
}
In the preced



 */
/*
int i = 1;
while (i <= 10)
{
    if ((i % 2) == 0)
        continue;
    Console.WriteLine($"{i++}");
}
*/

