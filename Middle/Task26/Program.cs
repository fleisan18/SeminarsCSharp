// 26. Возведите число А в натуральную степень B используя цикл
double A = new Random().Next(-100,100);
int B = new Random().Next(1,15);
double NatDegree(double a, int d)
{
    double a1 = a;
    for(int i=1; i<d; i++)
    {
        a = a*a1;
    }
    return a;
}
Console.WriteLine($"{A} в степени {B} = {NatDegree(A, B)}");
