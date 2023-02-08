// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if (number>9999 && number<100000)
{
    int number1 = number/1000;
    int number2 = number%100;
    if (number1/10==number2%10 && number1%10==number2/10)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ является палиндромом");
    }
}
else 
{
    Console.WriteLine("Заданое число не соответствует условию!");
}