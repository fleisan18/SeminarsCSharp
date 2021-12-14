// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
int row = 5;
int[,] PascaleTriangle = new int [row, row];
const int cellWidth = 4;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        PascaleTriangle[i,0] = 1;
        PascaleTriangle[i,i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            PascaleTriangle[i,j] = PascaleTriangle[i-1,j-1] + PascaleTriangle[i-1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if(PascaleTriangle[i,j] !=0) System.Console.Write($"{PascaleTriangle[i,j], cellWidth}");
        }
        System.Console.WriteLine();
    }
}
FillTriangle();
PrintTriangle();