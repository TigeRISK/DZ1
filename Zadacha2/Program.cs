//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());
int maxNum = Math.Max(Math.Max(numA, numB), numC);
{
    Console.WriteLine(maxNum);
}