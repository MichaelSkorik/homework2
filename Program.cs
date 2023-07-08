//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Enter three-digit number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Second digit is " + (num / 10) % 10);
