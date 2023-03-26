// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите число 1 => ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число 2 => ");
int number2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число 3 => ");
int number3 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Максимальное число = {Math.Max(number1, Math.Max(number2, number3))}");