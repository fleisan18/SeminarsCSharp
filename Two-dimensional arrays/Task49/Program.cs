// 49.Показать двумерный массив размером m×n заполненный вещественными числами
int M = 10;
int N = 3;
double[,] CreateArray (int m, int n)
{
    double[,] array = new double [m,n];
    return array;
}

double[,] FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((new Random().NextDouble()*100),3);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(FillArray(CreateArray(M, N)));
