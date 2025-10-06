// See https://aka.ms/new-console-template for more information
using Enumerations;

Console.WriteLine("Hello, World!");
/*
 * Los  enum son conjuntos de datos que una variable puede tomar solo uno de ese conjunto 
 * ejemplo tengo una variable donde solo quiero ,norte,sur,este o oeste 
 * el enum se encarga de que esa variable tome solo uno de ese conjunto 
 */
/*
Orientation miDireccion = Orientation.north;//aqui accedemos al enum
Console.WriteLine($"mi direccion = {miDireccion}");
*/

//otro ejemplo
byte direccionByte;
string direccionString;
Orientation miDireccion = Orientation.west;
Console.WriteLine($"Mi direccion = {miDireccion}");
//aquis e usa cast para forsar la conversion de mi direccion en byte 
direccionByte = (byte)miDireccion;
direccionString = Convert.ToString( miDireccion );//aqui obtenemos el valor en cadena de el enum 
//tambien se puede utilizar  
//direccionString = miDireccion.ToString();
//imprimimos valores
Console.WriteLine($"byte equvalente = {direccionByte}");
Console.WriteLine($"string equivalente = {direccionString}");


//tambien es posible convertir un string a un valor enum en este caso se necesita de una sintaxis deferente

//(enumerationType)Enum.Parse(typeof(enumerationType), enumerationValueString);
//string myString = "north";
//orientation myDirection = (orientation)Enum.Parse(typeof(orientation),
//myString);

