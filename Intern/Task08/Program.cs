// 8. Показать четные числа от 1 до N

string EvenNums(int N)
{
    string evenNumsStr = "";
    for (int i = 2; i <=N; i +=2)
    {
        evenNumsStr = evenNumsStr + $"{i} ";
    }
    return evenNumsStr;
}
int N8 = 20;
Console.WriteLine(EvenNums(N8));