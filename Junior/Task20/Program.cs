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
        maxValueX = double.MaxValue;
        maxValueY = double.MaxValue;
    }
    if (b==2)
    {
        minValueX = -double.MaxValue;
        maxValueY=double.MaxValue;
    }
    if (b==3)
    {
        minValueX = -double.MaxValue;
        minValueY = -double.MaxValue;
    }
    if(b==4)
    {
        maxValueX = double.MaxValue;
        minValueY = double.MaxValue;
    }
    range = range + $"Диапазон по Х ({minValueX}; {maxValueX}), диапазон по Y ({minValueY}; {maxValueY})";
    return range;
}
Console.WriteLine($"Диапазон для {b} четверти: {Range(b)}");