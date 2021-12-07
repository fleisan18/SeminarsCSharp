// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

int IndexOfSmallestSum(int[] array)
{
    int length = array.Length;
    int min = array[0];
    int indexOfMin = 0;
    for (int i = 0; i < length; i++)
    {
        if (min > array[i])
        {
            array[i] = min;
            indexOfMin = i;
        }
    }
    return indexOfMin;
}

int SmallestSum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    int sumOfLine;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumOfLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfLine = sumOfLine + array[i, j];
        }
        sums[i] = sumOfLine;
    }
    int lineOfSmallestSum = IndexOfSmallestSum(sums);
    return lineOfSmallestSum;
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


int[,] array59 = FillArray(CreateArray(3, 4));
PrintTwoDimentionalArray(array59);
System.Console.WriteLine();

System.Console.WriteLine(SmallestSum(array59));