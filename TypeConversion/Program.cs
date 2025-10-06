// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
- Conversión implícita-La conversión del tipo A al tipo B es posible en todas las circunstancias,
y 
las reglas para realizar la conversión son lo suficientemente sencillas como para confiar 
en el compilador.
- 
➤ Conversión explícita: la conversión del tipo A al tipo B sólo es posible 
en determinadas circunstancias o cuando las reglas de conversión son lo suficientemente
complicadas como para merecer un complemento 
procesamiento adicional de algún tipo.
 
 */

//implicit conversions
//
//La conversión implícita no requiere ningún trabajo por su parte ni código adicional. 
//Considere el código 
//que se muestra aquí:

//var1 = var2;

//Implicit Numeric Conversions
/*
 * Cualquier tipo A cuyo rango de valores posibles encaje completamente dentro 
 * del rango de valores posibles 
 * del tipo B puede convertirse implícitamente en ese tipo.
 * 
 * 
 * 
 TYPE                 CAN SAFELY BE CONVERTED TO
byte                  short, ushort, int, uint, long, ulong, float, double, decimal
sbyte                 short, int, long, float, double, decimal
short                 int, long, float, double, decimal
ushort                int, uint, long, ulong, float, double, decimal
int                   long, float, double, decimal
uint                  long, ulong, float, double, decimal
long                  float, double, decimal
ulong                 float, double, decimal
float                 Double
char                  ushort, int, uint, long, ulong, float, double, decimal
 */

//Explicit Conversions
/*
 
Por lo tanto, puede modificar su ejemplo utilizando esta sintaxis para forzar
la conversión de un short
a byte:
byte destinationVar;
short sourceVar = 7;
destinationVar = (byte)sourceVar;
Console.WriteLine($"valVarFuente: {VarFuente}");
Console.WriteLine($"destinationVar val: {destinationVar}");

sourceVar val: 7
destinationVar val: 7
 */