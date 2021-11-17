// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] FillArray(int count)  // заполняем массив
{
    double[] a = new double [count];
    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(-100,100);
    }
    return a;
}

double[] arr = FillArray(15);

void PrintArray(double[] array) // метод печати
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);

double Diference(double[] array)
{
    int length = array.Length;
    double min = 0;
    double max = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
    return max - min;
}
Console.WriteLine($"Разница между min и max = {Diference(arr)}");


