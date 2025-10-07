// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Declarando arrays 

//sintax
//<baseType> [] <name>

//int myIntArray;
//myIntArray = 0;

//un arra se puede inicializar de dos maneras 
// 1
int[] myIntArray = { 5, 6, 7, 8 };

//2
int[] myArray = new int[4];
//int[] myIntArray = new int[5] { 5, 9, 10, 2, 99 };

// no hacer esto int[] myIntArray = new int[10] { 5, 9, 10, 2, 99 };
//const int arraySize = 5;
//int[] myIntArray2 = new int[arraySize] { 5, 9, 10, 2, 99 };

////example
//string[] friendName =
//{
//    "saul","luis","jose","oscar"
//};
//int i;
//Console.WriteLine($"here are {friendName.Length} of my friends");

////recorremos el array 
//for (i = 0; i<=friendName.Length; i++)
//{
//    Console.WriteLine( friendName[i] );
//}

//recordar que para recorrer y mostrar  items de los elementos de un array 
//mediante un for es con i<type   si lo usamos <= no s epued accerder ya que el indice empieza desde 0 
//otra forma seria con un for each 

//multi dimencional arrays

//Una matriz multidimensional es simplemente una matriz que utiliza múltiples 
//    índices para acceder a sus elementos.

//Esto declararía un array de cuatro dimensiones. La asignación de valores también utiliza 
//    una sintaxis similar, con comas separando los tamaños. Declarar e inicializar la matriz bidimensional hillHeight, con una base 
//double, un tamaño x de 3, y un tamaño y de 4 requiere lo siguiente:

//double[,] hillHeight = new double[3, 4];
//Esta matriz tiene las mismas dimensiones que la anterior, es decir, tres filas y cuatro columnas. En 
//valores literales, estas dimensiones se definen implícitamente

//double[,] hillHeight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6, } };
//foreach (double  i in hillHeight)
//{
//    Console.WriteLine(i);

//}


//También es posible tener matrices dentadas, en las que las "filas" pueden tener tamaños variados. Para ello, necesita un 
//array en el que cada elemento sea otro array. También puedes tener matrices de matrices de matrices, o incluso 
//situaciones más complejas. Sin embargo, todo esto sólo es posible si las matrices tienen el mismo tipo base

//sintaxis de matris de matrises 
int[][] jaggedIntArray;

//Por desgracia, inicializar matrices como ésta no es tan sencillo como inicializar matrices multidimensionales. 
//No puedes, por ejemplo, seguir la declaración anterior con esto:
//jaggedIntArray = new int[3][4];


//Aunque se pudiera hacer esto, no sería tan útil porque se puede conseguir el mismo efecto con 
//matrices multidimensionales simples con menos esfuerzo. Tampoco puedes usar código como este:
//    jaggedIntArray = { { 1, 2, 3 }, { 1 }, { 1, 2 } };

//Tienes dos opciones. Puedes inicializar la matriz que contiene otras matrices 
//    (llamémoslas submatrices para mayor claridad) 
//    y luego inicializar las submatrices a su vez:

//jaggedIntArray = new int[2][];
//jaggedIntArray[0] = new int[3];
//jaggedIntArray[1] = new int[4];

//Como alternativa, puede utilizar una forma modificada de la asignación literal anterior:

//jaggedIntArray = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1 },
// new int[] { 1, 2 } };

//Esto puede simplificarse si la matriz se inicializa en
//    la misma línea en la que se declara, de la siguiente manera:

//     int[] { 1, 2, 3 }, new int[] { 1 },
// new int[] { 1, 2 } };

