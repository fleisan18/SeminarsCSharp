// 69. Найти сумму элементов от M до N, N и M заданы

int Sum (int m, int n)
{
    if(m==n) return n;
    else
    {
        if(m<n) return m+Sum(m+1,n);
        else return m+Sum(m-1, n);
    }
}


System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());


int result = (Sum(M,N));
System.Console.WriteLine(result);