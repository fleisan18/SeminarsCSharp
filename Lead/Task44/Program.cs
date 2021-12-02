// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы
// x = (b2 - b1) / (k1 - k2)
// y = k1x+b1
double k1 = 4;
double k2 = 6;
double b1 = 10;
double b2 = 5;

bool Parallelism (double k1, double k2) //проверка на параллельность
{
    bool res = k1%k2==0||k2%k1==0;
    return res;

}

string FindX(double k1, double k2, double b1, double b2)
{
    bool parall = Parallelism(k1,k2);
    string res = string.Empty;
    if(parall !=true) res = $"{(b2 - b1) / (k1 - k2)}";
    else res = "Прямые параллельны";
    return res;
}

string pX = FindX(k1, k2, b1, b2);

string FindY(string X, double k, double b)
{
    string res = string.Empty;
    bool parall = Parallelism(k1,k2);
    if(parall != true)
    {
        double x = Convert.ToDouble(X);
        res = $"{k * x + b}";
    }
    return res;
}

string pY = FindY(pX, k1, b1);

System.Console.WriteLine($"{pX}; {pY}");
