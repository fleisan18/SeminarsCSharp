﻿// 10. Показать вторую цифру трёхзначного числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 10: Показать вторую цифру трёхзначного числа"); //лишняя красота
// Лейсан Файзуллина 
int a10 = new Random().Next(100, 1000);
Console.WriteLine($"a: {a10}");
void SecondNumber(int a)
{
    a = a % 100;
    a = a / 10;
    Console.WriteLine($"Вторая цифра числа: {a}");
}
SecondNumber(a10);

// Альтернатива без void методов
int SecondNum(int a)
{
    return (a % 100) / 10;
}
Console.WriteLine($"Вторая цифра числа: {SecondNum(a10)}");

// Альтернатива 2
int SecondNum2(int a) => (a % 100) / 10; //или так
Console.WriteLine($"Вторая цифра числа: {SecondNum2(a10)}");

