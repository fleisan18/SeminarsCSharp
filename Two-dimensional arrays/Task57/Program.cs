// 57.Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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

int[] Select(int[] array)
{
    int temp;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length+1; j++)
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

int[,] SelectTwoDimentArray(int[,] array)
{
    int[] line = new int[array.GetLength(1)];
    int[] sortLine = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            line[j] = array[i, j];

        }
        sortLine = Select(line);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = sortLine[k];
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
int[,] array57 = (FillArray(CreateArray(3, 3)));
int[,] SelectArray = SelectTwoDimentArray(array57);

PrintArray(SelectArray);

