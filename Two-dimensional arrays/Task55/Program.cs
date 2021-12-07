// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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


double[] Average(int[,] array)
{
    double[] average = new double[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++)
    {

        int sum = 0;

        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }

        average[j] = (double)sum/array.GetLength(0);
    }
    return average;
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

void PrintArray1(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
            System.Console.Write($"{array[i]} ");
        
    }
}
int[,] array1 = (FillArray(CreateArray(4, 4)));
double[] arr55 = Average(array1);
PrintArray(array1);
System.Console.WriteLine();
PrintArray1(arr55);
