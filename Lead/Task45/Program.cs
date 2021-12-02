// 45. Показать числа Фибоначчи
int N = new Random().Next(1, 20);

int Fibon2(int n) //2, через рекурсию
{

    if (n == 1 || n == 2) return 1;
    else return Fibon2(n - 1) + Fibon2(n - 2);
}

void PrintNumbers(int n) //метод печати чисел (в Fibon2)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.Write($"{Fibon2(i)} ");
    }
}
System.Console.WriteLine(N);

System.Console.WriteLine();


PrintNumbers(N);