//15. Дано число. Проверить кратно ли оно 7 и 23
int a15 = new Random().Next(-1000, 1000);
bool Multiple(int a)
{
    return (a % 7 == 0) && (a % 23 == 0);
}
Console.WriteLine($"Число {a15} кратно 7 и 23? {Multiple(a15)}");

