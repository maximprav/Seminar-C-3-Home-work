// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату X первой точки:");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки:");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки:");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки:");
int zB = int.Parse(Console.ReadLine());
double number = Math.Round(Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA)),2);

Console.WriteLine($"Длина отрезка между заданными точками равна {number}");