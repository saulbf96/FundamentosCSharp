// See https://aka.ms/new-console-template for more information

//sentencia Switch 
//la sentencia switch tiene un break por cada case 
//La sentencia break aquí simplemente termina la sentencia switch, y el procesamiento continúa en la sentencia 
//que sigue a la estructura

//ejemplo sencillo se switch 

//declaramos constantes;
using System.Diagnostics;

const string myName = "saul";
const string niceName = "yazmin";
const string sillName = "pechuga";
string name;
//pedimos ingresar el nombre 
Console.WriteLine("whats is your name?");
name = Console.ReadLine();

switch (name.ToLower())//ToLower lo que hace es covertit texto en minusculas 
{
	case myName:
		Console.WriteLine("You have the same name as me ");
		break; //recordar cuando se cumple llega aqui y ya no sigue las demas instrucciones.
	case niceName:
		Console.WriteLine("Good, What a nice name you have!");
		break;
	case sillName:
		Console.WriteLine("That's  a very silly name");
		break;
}
Console.WriteLine($"Hello {name}");
Console.ReadKey();