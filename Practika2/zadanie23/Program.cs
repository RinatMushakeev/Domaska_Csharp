// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
System.Console.Write("Введите число N: ");
int numberN  = Convert.ToInt32(Console.ReadLine());
if (numberN >= 1)
{
    Console.Write($"{numberN} -> ");
    for (int i = 1; i <= numberN; i++)
    {
        System.Console.Write(Math.Pow(i, 3) + ", ");
    }
}
else
{
    Console.WriteLine($"Число меньше 1");
}
