// 72. Написать программу возведения числа А в целую стень B

int Degree(int a, int b)
{
    if (b == 0) return 1;
    else 
    {
        if (b % 2 == 0) return Degree(a * a, b / 2);
        else return Degree(a, b - 1) * a;
    }
}

Console.WriteLine("Введите основание степени");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите показатель степени");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(A, B));