//48. Показать двумерный массив размером m×n заполненный целыми числами
int M = 10;
int N = 3;
int[,] CreateArray (int m, int n)
{
    int[,] array = new int [m,n];
    return array;
}

int[,] FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-50,50);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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