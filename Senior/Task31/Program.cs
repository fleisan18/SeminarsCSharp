//31.Задать массив из 8 элементов и вывести их на экран

int[] Method31 (int count)
{
    int[] array = new int [count];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-100,100);
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
PrintArray(Method31(8));