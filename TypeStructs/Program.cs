// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Route myRoute;
int myDirection = -1;
double myDistance;
Console.WriteLine("1) North\n2) South\n3)East\n4) West");
do
{
    Console.WriteLine("Select a Direction:");
    myDirection = Convert.ToInt32(Console.ReadLine());


} while ((myDirection < 1) || (myDirection >4));
Console.WriteLine("input a distance:");
myDistance = Convert.ToDouble(Console.ReadLine());
myRoute.direction = (Orientacion)myDirection;
myRoute.distance = myDistance;
Console.WriteLine($"myRoute specifies a direction of {myRoute
.direction} " +
 $"and a distance of {myRoute.distance}");
/*
El struct (abreviatura de structure) es precisamente eso. Es decir, los structs
son estructuras de datos compuestas por varios
piezas de datos, posiblemente de diferentes tipos. Permiten definir tipos propios de variables  
 */
/*
 basándose en esta estructura. Por ejemplo, supongamos que desea almacenar la ruta 
a un lugar desde un punto de partidapunto de partida, donde la ruta consiste en una dirección 
y una distancia en millas. Para simplificar, puedepuede suponer que la dirección es uno de
los puntos de la brújula (de forma que pueda representarse utilizando la
enumeración de orientación de la sección anterior), y que la distancia en millas se puede representar 
 */

enum Orientacion : byte
{
    north = 1,
    south = 2,
    east = 3,
    northEast = 4
}

struct Route
{
    public Orientacion direction;
    public double distance;
}


