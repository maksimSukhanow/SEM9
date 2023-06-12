// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbers(int num, int num2)
{
    if (num == num2+1) return 0;
    return num + SumNumbers(num+1,num2);
}

int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNumbers(num, num2));