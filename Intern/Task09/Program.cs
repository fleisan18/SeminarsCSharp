// 9. Показать последнюю цифру трёхзначного числа

// Лейсан Файзуллина 
int a9 = new Random().Next(100, 1000);

int LastNum(int a)
{
    return  a % 10;
}
Console.WriteLine($"Последнияя цифра {a9} - {LastNum(a9)}");


