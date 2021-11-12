//20. Задать номер четверти, показать диапазоны для возможных координат
int b = new Random().Next(1,5);
string Range (int b)
{
    double minValueX = 0;
    double maxValueX =0;
    double minValueY=0;
    double maxValueY=0;
    string range = string.Empty;

    if (b==1)
    {
        maxValueX = 1.7 * Math.Pow(10, 308);
        maxValueY = 1.7 * Math.Pow(10, 308);
    }
    if (b==2)
    {
        minValueX = -1.7 * Math.Pow(10, 308);
        maxValueY=1.7 * Math.Pow(10, 308);
    }
    if (b==3)
    {
        minValueX = -1.7 * Math.Pow(10, 308);
        minValueY = -1.7 * Math.Pow(10, 308);
    }
    if(b==4)
    {
        maxValueX = 1.7 * Math.Pow(10, 308);
        minValueY = -1.7 * Math.Pow(10, 308);
    }
    range = range + $"Диапазон по Х ({minValueX} - {maxValueX}), диапазон по Y ({minValueY} - {maxValueY})";
    return range;
}
Console.WriteLine($"Диапазон возможных координат для {b} четверти: {Range(b)}");