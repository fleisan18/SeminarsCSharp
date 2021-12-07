// 61. Найти произведение двух матриц
int[,] CreateArray(int m, int n)
{
    return new int[m, n];
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] SquareOfArrays(int[,] a, int[,] b)
{
    int[,] square = new int[a.GetLength(0), b.GetLength(1)];
 
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(0); j++)
        {
            for (int k = 0; k < b.GetLength(1); k++)
            {
                square[i, k] += a[i,j] * b[j,k];
            }
        }
    }
    return square;
}

void PrintTwoDimentionalArray(int[,] array)
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
int[,] a = FillArray(CreateArray(3,3));
int[,] b = FillArray(CreateArray(3,3));

PrintTwoDimentionalArray(a);
System.Console.WriteLine();
PrintTwoDimentionalArray(b);
System.Console.WriteLine();

PrintTwoDimentionalArray(SquareOfArrays(a,b));