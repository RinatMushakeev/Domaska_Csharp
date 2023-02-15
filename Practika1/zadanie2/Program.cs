// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (number1 > number2 && number1 > number3) Console.WriteLine($"Из трех введенных чисел {number1}, {number2}, {number3} максимальным является первое {number1}"); 
if (number2 > number1 && number2 > number3) Console.WriteLine($"Из трех введенных чисел {number1}, {number2}, {number3} максимальным является второе {number2}"); 
if (number3 > number1 && number3 > number2) Console.WriteLine($"Из трех введенных чисел {number1}, {number2}, {number3} максимальным является третье {number3}"); 

Console.WriteLine();