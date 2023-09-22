

Console.WriteLine("-----Usando el metodo System.Math------");

//Calculamos el numero mayor 
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);


Console.WriteLine("----------------------------------------");

//Genramos un numero aleatorio

Random numero = new Random();
int roll1 = numero.Next(50);
int roll2 = numero.Next(1,10);
int roll3 = numero.Next();
Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);