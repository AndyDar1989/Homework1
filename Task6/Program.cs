/*Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/
Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = number%10;
Console.Write($"Last number is {lastNumber}");
