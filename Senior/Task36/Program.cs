// 36.Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int[] FillArray (int count)    // заполняем массив 
{
    int[] array = new int [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (100,1000);
    }
    return array;
}

int OddNumber (int[] a) // считаем количество нечетных чисел
{
    int length = a.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(a[i]%2!=0) count++;
    }
    return count;
}

int EvenNumber (int[] a) // считаем количество четных чисел
{
    int length = a.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(a[i]%2==0) count++;
    }
    return count;
}

int[] a = FillArray(10);

Console.WriteLine($"В массиве {OddNumber(a)} нечетных чисел");
Console.WriteLine($"В массиве {EvenNumber(a)} четных чисел");
