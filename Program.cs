﻿// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine();
// System.Console.WriteLine("*Задача № 2. Поиск наибольшего значения из двух чисел*");
// System.Console.WriteLine();

// System.Console.WriteLine("Введите первое число");
// if (!int.TryParse(Console.ReadLine(), out int number1))
// {
//     Console.WriteLine("Введено не целое число");
//     return;
// }
// System.Console.WriteLine("Введите второе число");
// if (!int.TryParse(Console.ReadLine(), out int number2))
// {
//     Console.WriteLine("Введено не целое число");
//     return;
// }

// if (number1 > number2)
//     System.Console.WriteLine($"max = {number1}");

// else
//     System.Console.WriteLine($"max = {number2}");
// System.Console.WriteLine();

// // Задача 4
// // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

System.Console.WriteLine();
System.Console.WriteLine("*Задача № 4. Поиск наибольшего значения из трех чисел*");
System.Console.WriteLine();

System.Console.WriteLine("Введите первое число");
if (!int.TryParse(Console.ReadLine(), out int number1))
{
    Console.WriteLine("Введено не целое число");
    return;
}
System.Console.WriteLine("Введите второе число");
if (!int.TryParse(Console.ReadLine(), out int number2))
{
    Console.WriteLine("Введено не целое число");
    return;
}
System.Console.WriteLine("Введите третье число");
if (!int.TryParse(Console.ReadLine(), out int number3))
{
    Console.WriteLine("Введено не целое число");
    return;
}

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

System.Console.WriteLine($"max = {max}");