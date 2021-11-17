// 37.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
double[] FillArray (int count) // заполняем массив
{
    double[] array = new double [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-100,100);
    }
    return array;
}

void PrintArray(double[] arr) // метод печати
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int Number (double[] a)
{
    int length = a.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(a[i]>=10&&a[i]<=99) count++;
    }
    return count;
}

double[] b = FillArray(123);
PrintArray(b);

int result = Number(b);
Console.WriteLine($"Из [10,99] {result} чисел");