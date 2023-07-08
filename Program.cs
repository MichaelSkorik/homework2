//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Enter number");
string num = Console.ReadLine();
if(int.Parse(num) % 1 < 100)
{
    Console.WriteLine("There is no third digit");
}
else
{
    Console.WriteLine("Third digit is " + num[2]);
}