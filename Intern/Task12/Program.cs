// 12. Удалить вторую цифру трёхзначного числа
int a12 = new Random().Next(100,1000);
int removeMidNum(int a)
{
    return ((a / 100) * 10) + a % 10;
}
Console.WriteLine($"Было: {a12}, стало: {removeMidNum(a12)}");

