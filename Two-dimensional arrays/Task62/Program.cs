// 62. В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

(int iMinRow,int iMinCol) Min(int[,] array)
{
    int min = array[0,0];
    int indexRow = 0;
    int indexCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexRow = i;
                indexCol = j;
            }
        }
    }
    return (indexRow, indexCol);
}

int[,] DeleteColRow(int[,] array)
{
    (int,int) minIndexes = Min(array);
    for (int i = minIndexes.Item1; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = array[i+1, j];
        }
    }
    for (int j = minIndexes.Item2; j < array.GetLength(1)-1; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i,j] = array[i,j+1];
        }
    }
    return array;
}

void PrintResizedArray (int[,] array)
{
     for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
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

int[,] array62 = FillArray(CreateArray(3,3));
PrintTwoDimentionalArray(array62);

System.Console.WriteLine();

System.Console.WriteLine(Min(array62));

System.Console.WriteLine();

int[,] changedArray62 = DeleteColRow(array62);
PrintResizedArray(changedArray62);
