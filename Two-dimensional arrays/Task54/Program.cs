// 54. В матрице чисел найти сумму элементов главной диагонали
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

int Sum (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j< array.GetLength(1); j++)
       {
           if(i==j) sum = sum+array[i,j];
       }
    }
    return sum;
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
int [,] array54 = FillArray(CreateArray(3,3));
PrintArray(array54);

System.Console.WriteLine();
Console.WriteLine(Sum(array54));