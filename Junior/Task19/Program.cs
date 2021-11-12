//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double X = new Random().Next(-1000, 1000);
double Y = new Random().Next(-1000, 1000);
string Quarter(double x, double y)
{
    string result = "";
    if (x != 0 && y != 0)
    {
        if (x > 0 && y > 0)  result = result + "Точка с координатами" + x + y + "в 1 четверти";
        if (x < 0 && y > 0)  result = result + "Точка с координатами" + x + y + "во 2 четверти";
        if (x < 0 && y < 0)  result = result + "Точка с координатами" + x + y + "в 3 четверти";
        if (x > 0 && y < 0)  result = result + "Точка с координатами" + x + y + "в 4 четверти";
    }
    else
    {
        result = result + "Точка с координатами" + x + y + "на оси";
    }
    return result;
}

Console.WriteLine(Quarter(X, Y));
