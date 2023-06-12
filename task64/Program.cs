﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string AllNumbers(int num)
{
    if (num == 1) return $"{1}";
    return  $" {num}" + $", {AllNumbers(num-1)}";
}

int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(AllNumbers(num)); 