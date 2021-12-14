// 63. Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран 
// выводя индексы соответствующего элемента

int[,,] ThreeDimentArray = new int [4,5,5];
int[,,] FillArray(int[,,] array)
{
    int n =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = n++;
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.WriteLine($"{i} {j} {k} - {array[i,j,k]}");
            }
        }
    }
}
PrintArray(FillArray(ThreeDimentArray));