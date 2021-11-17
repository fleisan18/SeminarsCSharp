//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] Method32 (int count)
{
    int[] array = new int [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (0,2);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
PrintArray(Method32(8));