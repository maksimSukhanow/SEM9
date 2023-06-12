// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


 int Ackermann(int num, int num2)
{
    if (num == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return Ackermann(num - 1, 1);
    }
    else
    {
        return Ackermann(num - 1, Ackermann(num, num2 - 1));
    }
}




int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Ackermann(num, num2));