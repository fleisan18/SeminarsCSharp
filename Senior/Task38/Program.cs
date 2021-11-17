//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] Array(int count)
{
    int[] arr = new int [count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
    return arr;
}
int[] arr = Array(20);

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2==0)
        {
            sum = sum +arr[i];
        }
    }
    return sum;
}
Console.WriteLine($"В массиве сумма чисел на нечетных позициях равна {Sum(arr)}");