// 56. Написать программу, которая обменивает элементы первой строки и последней строки

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

int[,] ChangeStringsInArray(int[,] array, int firstString, int lastString)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[firstString-1, j];
        array[firstString-1, j] = array[lastString -1, j];
        array[lastString -1, j] = temp;
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

int m = 5;
int n = 4;
int[,] array56 = FillArray(CreateArray(m,n));
PrintArray(array56);
System.Console.WriteLine();

int[,] changedArray = ChangeStringsInArray(array56, 1, m);
PrintArray(changedArray);



