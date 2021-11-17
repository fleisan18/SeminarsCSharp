//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] FillArray (int count)    // заполняем массив из [0,9]
{
    int[] array = new int [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (0,10);
    }
    return array;
}

int[] b = FillArray(12);

int Sum1(int[] array)    // для положительных элементов массива 
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if(array[i]>0) sum = sum + array[i];
    }
    return sum;
}

int Sum2(int[] array)    // для отрицательных элементов массива 
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if(array[i]<0) sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine($"Сумма положительных чисел в массиве = {Sum1(b)}");
Console.WriteLine($"Сумма отрицательных чисел в массиве = {Sum2(b)}");