﻿// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 2: Даны два числа. Показать большее и меньшее число"); //лишняя красота

// Лейсан Файзуллина
int a2 = new Random().Next(-50, 500);
int b2 = new Random().Next(-50, 500);
void BiggerSmaller(int a, int b)
{
    if (a < b)
    {
        Console.WriteLine($"min = {a}, max = {b}");
    }
    else
    {
        Console.WriteLine($"min = {b}, max = {a}");
    }
}
BiggerSmaller(a2, b2);

// Альтернатива без void метода
int Big(int NumA, int NumB)
{
    if (NumA < NumB)
    {
        return NumB;
    }
    return NumA;
}
int Small(int NumA, int NumB)
{
    if (NumA < NumB)
    {
        return NumA;
    }
    return NumB;
}
Console.WriteLine($"Большее:{Big(a2,b2)}, Меньшее: {Small(a2,b2)}");
