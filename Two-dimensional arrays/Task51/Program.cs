// 51.Задать двумерный массив следующим правилом: Aₘₙ = m+n

int N = 7;
int K = 3;
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
            array[i,j] = i+j;
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

int[,] array1 = (FillArray(CreateArray(N,K)));
PrintArray(array1);
