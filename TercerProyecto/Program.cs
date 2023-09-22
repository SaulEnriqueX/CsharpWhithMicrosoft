// See https://aka.ms/new-console-template for more information
Console.WriteLine("Desarrollo de lógica de decisión con instrucciones if");

Random numero = new Random();
int roll1 = numero.Next(1, 6);
int roll2 = numero.Next(1, 6);
int roll3 = numero.Next(1, 6);
/*
roll1 = 6;
roll2 = 6;
roll3 = 6;
*/
int resultados = roll1 + roll2 + roll3;
Console.WriteLine($"{roll1}+{roll2}+{roll3} = {resultados}");


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))

    {
        Console.WriteLine("Felicidades Obtuviste 6 puntos adicionales");
        resultados += 6;
    }
    else
    {
        Console.WriteLine("Felicidades Obtuviste 2 puntos adicionales");
        resultados += 2;
    }
}


if (resultados >= 16)
{
    Console.WriteLine("You Win a new car");
}

else if (resultados >= 10)
{
    Console.WriteLine("You Win a new laptop");
}

else if (resultados >= 7)
{
    Console.WriteLine("You win a trip for two");
}

else
{
    Console.WriteLine("You win a kitten!");
}


Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Usamos un nuevo Metodo");

string mensaje = "Mi nombre es saul enrique";
bool result = mensaje.Contains("nombre");
Console.WriteLine(result);