// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или 
// сообщить, что это невозможно (задача только для квадратных матриц)

int[,] CreateArray()
{
    System.Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
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

int[,] Transposition (int[,] array)
{
    int[,] transposedArray = new int [array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array.GetLength(0)==array.GetLength(1)) 
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                transposedArray[j,i] = array[i,j];
            }
        }
        else
        {
            System.Console.WriteLine("Транспонирование невозможно");
            break;
        }
    }
    return transposedArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array.GetLength(0)!=array.GetLength(1)) break;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] array58 = FillArray(CreateArray());
PrintArray(array58);
System.Console.WriteLine();

int[,] transposedArray58 = Transposition(array58);
PrintArray(transposedArray58);