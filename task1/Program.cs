﻿// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
//  а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число => ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число => ");
int number2 = Convert.ToInt32(System.Console.ReadLine());
if (number1 > number2)
{
    System.Console.WriteLine($"Чило {number1} больше числа {number2}");
}
else
{
    System.Console.WriteLine($"Чило {number2} больше числа {number1}");
}