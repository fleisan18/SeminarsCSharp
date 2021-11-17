// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a13 = new Random().Next(-100, 100);
int k13 = new Random().Next(0, 16);

bool ifmultiply (int A, int K) //метод проверки кратности
{
    return A%K==0;
}
bool multiply = ifmultiply(a13, k13);

string Remainder(int A, int K, bool multiply) //выводим остаток, если число не кратно
{
    string result = string.Empty;
    if (multiply) return result = $"{A} кратно {K}";
    else return result = $"Остаток = {A % K}";
}
string res = Remainder(a13, k13, multiply);
Console.WriteLine($"{a13} кратно {k13}? {res}");