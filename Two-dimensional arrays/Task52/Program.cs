// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateArray (int m, int n)
{
    return new int [m,n];
}

int[,] FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}
int[,] SquareEven (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j] * array[i,j];
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

int m = 4;
int n = 5;
int[,] array1 = (FillArray(CreateArray(m,n)));
PrintArray(array1);
System.Console.WriteLine();
PrintArray(SquareEven(array1));

