// See https://aka.ms/new-console-template for more information


Console.WriteLine("-----TRABAJANDO CON MATRICES-----");

String[] fraudulentOrderIDs  = new String[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


Console.WriteLine("-----OTRO EJEMPLO-----");

string[] fraudulentOrderID = { "A1234", "B4567", "C7890" };

Console.WriteLine($"First: {fraudulentOrderID[0]}");
Console.WriteLine($"Second: {fraudulentOrderID[1]}");
Console.WriteLine($"Third: {fraudulentOrderID[2]}");

fraudulentOrderID[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderID[0]}");
Console.WriteLine($"There are {fraudulentOrderID.Length} fraudulent orders to process.");