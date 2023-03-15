// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string prompt)
{
    Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int WriteNumbers(int m, int n)
{
    if (m < n)
    {
        return m + WriteNumbers(m + 1, n);
    }
    return m;
}


int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
if (m < n || m == n)
{
    System.Console.WriteLine(WriteNumbers(m, n));
}
else if (m > n)
{
    System.Console.WriteLine("Число M больше числа N");
}
