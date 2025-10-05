// See https://aka.ms/new-console-template for more information


/*
 * Los bucles do funcionan de la siguiente manera: Se ejecuta el código que has
 * marcado para el bucle, se realiza una prueba booleana 
y el código se ejecuta de nuevo si esta prueba es verdadera, 
y así sucesivamente. Cuando la prueba es falsa, el bucle se cierra.
 */
//Structure
/*do
{
    //codigo por hacer 

} while (true);
*/

//por ejemplo podemos escribir los numeros del 1 al 10 
/*
int i = 1;
do
{
    Console.WriteLine($"{i++}");
} while (i <= 10);
*/

//ejemplo sencillo 

//declaramos variables 
/*
double balance, interesRate, targetBalance;
Console.WriteLine("What is your  currente balance?");
balance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your current annual interest rate (in %)? ");
interesRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
Console.WriteLine("What balance would  you like  to have?");
targetBalance = Convert.ToDouble(Console.ReadLine());
int totalYears = 0;
do
{
    balance *= interesRate;
    ++totalYears;
} while (balance < targetBalance);
Console.WriteLine($"in {totalYears} year {(totalYears == 1 ? "" : "s")}" +
    $"you'll have a balance  of {balance}.");
Console.ReadKey();*/

/*
 * Pide al usuario que ingrese una contraseña hasta que escriba "1234".
Cuando la escriba correctamente, muestra:
 */
//pedimos la contraseña 
/*
const string contraseña = "123"; 
string input;
Console.WriteLine("Escribe  la contraseña correcta");
input = Console.ReadLine();
//Console.WriteLine("La contraeeña es incorrecta vuelve a intentarlo");

do
{
    Console.WriteLine("La contraseeña es incorrecta vuelve a intentarlo");
    Console.WriteLine("Escribe  la contraseña correcta");
    input = Console.ReadLine();
    
    

} while (input != contraseña);
Console.WriteLine("Acceso Autorizado");
*/

/*
 Pide al usuario que ingrese números hasta que escriba uno negativo.
Al final muestra cuántos números positivos ingresó.
 */

/*
int numero;//variable para almacenar numero ingresados 

int i = 0;//acumulador para sumar los numeros ingresados 
do
{
    //pedimos al usuario los numeros 
    Console.WriteLine("Escribe numeros positivos si ingresas negativos se termina el programa");
    numero = Convert.ToInt32(Console.ReadLine());
    //solo sumamos si el numero es positivo
    if(numero  > 0)
    {
        i += numero;
    }
} while (numero > 0);
Console.WriteLine("Escribiste un numero negativo");
Console.WriteLine($"La suma de tus  numeros  ingresados son: {i}");//i++ me dice cuantos intentos o cuantas veces ingredse
*/

/*
 Menú interactivo

Muestra un menú así:

1. Sumar
2. Restar
3. Salir
Permite al usuario elegir una opción, realiza la operación
(pide números si es suma o resta) y vuelve a mostrar el menú hasta que elija salir.
 */
/*
double numero1, numero2,resultado;
int menu;

do
{
    Console.WriteLine("Escribe una opcion a realizar");
    Console.WriteLine("Menu");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Salir");
    menu = Convert.ToInt32(Console.ReadLine());


    if (menu == 1)
    {
        Console.WriteLine("Ecribe el primer numero");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero");
        numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = numero1 + numero2;
        Console.WriteLine($" la suma de {numero1} y {numero2}  es : {resultado}");


    }
    else if(menu == 2)
    {
        Console.WriteLine("Ecribe el primer numero");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero");
        numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = numero1 - numero2;
        Console.WriteLine($" la Resta de {numero1} y {numero2}  es : {resultado}");


    }
    else
    {
        Console.WriteLine("Opcion invalida intenta de nuevo");
    }
   


} while (menu != 3);//Repite el bloque mientras la opción NO sea 3
        //menu == 3   Repite el bloque mientras la opción sea 3

Console.WriteLine("Saliendo del programa....");
Console.WriteLine("Good Bye");
System.Environment.Exit(0);
*/

/*
 Tabla de multiplicar con repetición

Pide un número al usuario.

Muestra su tabla de multiplicar del 1 al 10.

Pregunta: “¿Quieres generar otra tabla? (s/n)”

Repite mientras el usuario responda "s".
 */
/*
int numero;//numo del que se hara la tabla
int i; //contador para multiplicar del 1 al 10 
string respuesta;

//inicio do 
do
{
    //pedimos al usuario el numero para generar la tabla 
    Console.WriteLine("Escriba el numero para generar su tabla");
    numero = Convert.ToInt32(Console.ReadLine());

    //bucle interno para imprimir del 1 al 10 
    
    
        //inicializamos contador 
        i = 1;
    do
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} * {i} = {resultado}");
        i++; //incrementamos el contador.
    } while (i <= 10); //repetimos hasta 10

    //preguntamos al usuario si desea otra tabla
    Console.WriteLine("¿quieres generar otra tabla? (s/n)");

    respuesta = Console.ReadLine()?.ToLower();



    

} while (respuesta == "s");//repetimos mientras el usuario diga s 

Console.WriteLine("Programa terminado");
*/

/*
 Adivina el número

La computadora genera un número aleatorio entre 1 y 10.

El usuario intenta adivinarlo.

El programa indica si el intento es “muy alto” o “muy bajo” y se repite hasta que acierte.
 */


Random random = new Random();//creamos objeto de Random
int numeroRandom; //aqui se guardara el numero aleatorio
numeroRandom = random.Next(1, 10);//aqui decimos solo el rangodel 1 al 10
int numero; //numero donde se guardara el numero del usuario
do
{

    Console.WriteLine("Adivina el numero del 1 al 10");
    Console.WriteLine("ingresa el numero");
    numero = Convert.ToInt32(Console.ReadLine());//pedimos el numero del usuario y lo guardamos 
    if (numero < numeroRandom)//numero es menor a ramdom entonces tamos muy bajo 
    {
        Console.WriteLine("muy bajo");
    }
    else if (numero > numeroRandom)//si numero es mayor a random entonces es tamos muy altos 
    {
        Console.WriteLine("Muy alto");
    }
    else if (numero == numeroRandom) //si numero es igual a random entonces adivinamos 
    {
        Console.WriteLine($"Felicidades adivinaste el numero es {numeroRandom}");
    }
} while (numero != numeroRandom);//hacersi numero es diferente de random de lo contrario  +
                                 //si es igual se termina programa 

