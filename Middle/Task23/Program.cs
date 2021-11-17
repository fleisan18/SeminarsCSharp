
// 23. Показать таблицу квадратов чисел от 1 до N 
int N = 15;
double[] Square(int N)
{
    double[] A = new double[N];
    for (int i = 0; i < N; i++)
    {
        A[i] = Math.Pow(i+1, 2);
    }
    return A;
}

double[]B = Square(N);

void PrintArray(double[] b)
{
    int length = b.Length;
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine(b[i]);
    }
}
PrintArray(B);


