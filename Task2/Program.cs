/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if ( firstNumber>secondNumber && firstNumber>thirdNumber)
{
    Console.WriteLine($"Maximal number is {firstNumber}");
}
else if (secondNumber>firstNumber && secondNumber>thirdNumber)
{
    Console.WriteLine($"Maximal number is {secondNumber}");
}
else
{
   Console.WriteLine($"Maximal number is {thirdNumber}"); 
}
