// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number!.Length == 5)
{
    // int a1 = Convert.ToInt32(Convert.ToString(number![0]));
    // int a2 = Convert.ToInt32(Convert.ToString(number![1]));
    // int a4 = Convert.ToInt32(Convert.ToString(number![3]));
    // int a5 = Convert.ToInt32(Convert.ToString(number![4]));

    // if ((a1 == a5) && (a2 == a4))
    if ((number[0] == number[4]) && (number[1] == number[3]))
    {
        Console.WriteLine($"Число {number!} Палиндром");       
    }    
    else 
    {
        Console.WriteLine($"Число {number!} не Палиндром");
    }
        
}
else
{
    System.Console.WriteLine("Число не является пятизначным");
}