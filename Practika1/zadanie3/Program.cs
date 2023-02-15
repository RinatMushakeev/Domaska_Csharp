// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (number1 % 2 == 0 )
{
    Console.WriteLine($"Введенное число {number1} четное, ответ да");    
}
else
{
    Console.WriteLine($"Введенное число {number1} нечетное, ответ нет");    
}

Console.WriteLine();