// 35. Определить, присутствует ли в заданном массиве, некоторое число
int[] FillArray (int count)    // заполняем массив 
{
    int[] array = new int [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-100,100);
    }
    return array;
}

bool Here (int [] arr, int a)   //определяем наличие в массиве некоторого числа
{
    int length = arr.Length;
    bool number = false;
    for (int i = 0; i < length; i++)
    {
        if(arr[i] == a) number = true;
    }
    return number;
}
int a = new Random().Next(-10,10);
Console.WriteLine($"Находится ли в массиве {a}? - {Here(FillArray(10), a)}");
