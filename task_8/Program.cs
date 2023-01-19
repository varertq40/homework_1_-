// Задача 8: напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);

int Count = 2;

while (Count <= N)
{
    Console.WriteLine(Count);
    Count += 2;
}
