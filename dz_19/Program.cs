// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);

if (n / 10000 == n % 10  &&  n / 1000 % 10 == n/10 % 10)
    
{
    Console.WriteLine("Да");
}
    
else
{
    Console.WriteLine("Нет");
}
