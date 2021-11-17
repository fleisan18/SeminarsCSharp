// 24. Найти кубы чисел от 1 до N

double[] Cube(int n)
{
    double[] a = new double[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = Math.Pow(i+1,3);
    }
    return a;
}
void PrintArray(double[] arr) // метод печати
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int N = 15;
PrintArray(Cube(N));