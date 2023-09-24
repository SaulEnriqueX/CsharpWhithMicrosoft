// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----PRIMER EJEMPLO FOREACH-----");


string[] names = { "Rowena", "Robin", "Bao" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("-----SEGUNDO EJEMPLO FOREACH-----");

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

