// 46. Написать программу масштабирования фигуры
// задаем координатами точки
// фигура - прямоугольник, одна из вершин в (0,0)

int[,] Rectangle = new int[,]
{
    {1,2}, 
    {1,3}, 
    {5,2}, 
    {5,3}
};

int N = 2; // коэф. масштабирования

int[,] Scale(int[,] array, int n)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = n*array[i, j] - array[0, 0];
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

PrintArray(Rectangle);
System.Console.WriteLine();

int[,] ScaledRectangle = Scale(Rectangle, N);
PrintArray(ScaledRectangle);