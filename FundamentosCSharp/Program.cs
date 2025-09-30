// See https://aka.ms/new-console-template for more information


//the if statement example 
string comparison;
Console.WriteLine("Enter a number");// ingresamos un numero 
double var1 = Convert.ToDouble(Console.ReadLine());// aqui  convertimos lo que se ingresa a double;
Console.WriteLine("Enter  another number:");//pedimos ingresar otro numero 
double var2 = Convert.ToDouble(Console.ReadLine()); //convertimos lo que ingresa a double 
// aqui evaluamos si var2 es menor  a var1

if (var1 < var2)
{
    comparison = "less than"; //aqui asignamos el texto ala variable comparison
}
else
{
    if (var1 == var2)
        comparison = "equal to";
    else
        comparison = "greater than";
}
//imprimimos resultados
Console.WriteLine($"The first number is {comparison}"
+$"the secon number");
Console.ReadKey();

