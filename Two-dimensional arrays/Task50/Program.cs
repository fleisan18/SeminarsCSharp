// 50.В двумерном массиве n×k заменить четные элементы на противоположные
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
            array[i,j] = new Random().Next(-50,50);
        }
    }
    return array;
}

int[,] IsEven (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]%2==0) array[i,j] *=-1;
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
System.Console.WriteLine();
PrintArray(IsEven(array1));