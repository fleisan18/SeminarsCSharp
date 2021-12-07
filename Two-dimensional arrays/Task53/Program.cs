// 53.В двумерном массиве 
// показать позиции числа, заданного пользователем или 
// указать, что такого элемента нет

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
(int m, int n) FindElementInArray(int[,] array, int findValue)
{
    int m = -1;
    int n = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == findValue) 
            {
                m = i;
                n = j;
                break;
            }    
        }
        if (m != -1 && n != -1) break;
    }
    return (m, n);
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
Console.WriteLine();
Console.WriteLine("Введите целое число для поиска в массиве");
int findElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElementInArray(array1, findElement));


