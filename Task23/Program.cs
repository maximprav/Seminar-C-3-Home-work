// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите любое положительное число:");
int number = int.Parse(Console.ReadLine());
int count = 1;
if (number > 0)
{
    while (count < number)
    {
        Console.Write($"{count*count*count}, ");
        count++;
    }
}
if (count == number)
{
        Console.Write($"{count*count*count}. ");
}
else
{
    Console.Write($"Задано неверное число.");
}