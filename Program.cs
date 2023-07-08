//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Enter day of week");
int day = int.Parse(Console.ReadLine());
if(day == 7 && day == 8 )
{
    Console.WriteLine(day + " -> Yes");
}
else
{
    Console.WriteLine(day + " -> No");
}