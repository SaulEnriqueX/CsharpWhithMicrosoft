// See https://aka.ms/new-console-template for more information

/* Tipos de Variables */
string nombre = "Saul";
char apellido = 'G';
int edad = 24;
decimal sueldo = 1500.80M;
double bonificacion = 1500.80;
var sexo = "Masculino";

/* Concatenacion de cadenas */
Console.WriteLine("Hola mi nombre es " + nombre + " y mi apellido es " + apellido);
Console.Write("Soy un comentario en fila no doy salto de linea");

Console.WriteLine("-----------------------------------------------------------");

/* Interpolacion de cadenas */
Console.WriteLine($"hola me llamo {nombre} y mi apellido es {apellido} y mi edad es {edad}");
Console.WriteLine($"Mi sueldo es de {sueldo} y mi bonificacion es de {bonificacion}");
Console.WriteLine($"Mi sexo es {sexo}");

Console.WriteLine("-----------------------------------------------------------");

/* Secuencias de escape */

Console.WriteLine("Hola\nYo hago un salto de linea");
Console.WriteLine("Hola\tYo agrego cierto espacio entre las palabras");
Console.WriteLine("Hola\"Yo agrego la comilla doble para que pueda ser vista\"!!!!!");
Console.WriteLine("c:\\Yo solo imprimo\\un slash si buscas  una ruta");
Console.WriteLine(@"c:\permito que los caracteres especiales sean tratados literalmente");
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World! - Formato unicode despues de la U");

Console.WriteLine("-----------------------------------------------------------");

/* Operaciones Matematicas */

int suma = 8 + 7;           /* [+ - * / %] */
Console.WriteLine($"El resultado de la suma es {suma}");

Console.WriteLine("-----------------------------------------------------------");

/* Conversion de un tipo a otro o CASTEO */

int a = 8;
int b = 10;
Console.WriteLine((decimal)a/(decimal)b);

Console.WriteLine("-----------------------------------------------------------");

/* Operadores de asignacion */

int valor = 1;
//valor += 1 ;                  //  valor = valor + 1;
//valor -= 1 ;                  //  valor = valor - 1;
//valor *= 1 ;                  //  valor = valor * 1;
//valor ++ ;                    //  valor = valor + 1;
//valor -- ;                    //  valor = valor + 1; Postincremento
//++valor  ;                    //  valor = valor + 1; Preincremento
Console.WriteLine(valor);

Console.WriteLine("-------EJEMPLO DE POST Y PRE INCREMENTO-------");

int c = 5;
int d = 10;

int resultado1 = c++ + d; // resultado1 será 16 (a se incrementa después de la operación)
int resultado2 = ++c + d; // resultado2 será 17 (a se incrementa antes de la operación)
Console.WriteLine($"Primer Resultado de: {resultado1}\nSegundo Resultado de es :{resultado2}");

Console.WriteLine("-----------------------------------------------------------");
