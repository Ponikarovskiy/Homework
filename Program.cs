// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine();
System.Console.WriteLine("*Задача № 2. Поиск наибольшего значения из двух чисел*");
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

if (number1 > number2)
    System.Console.WriteLine($"max = {number1}");

else
    System.Console.WriteLine($"max = {number2}");
System.Console.WriteLine();
