//34. Написать программу замену элементов массива на противоположные
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

int[] Opposite(int[] arr) // заменяем элементы массива на противоположные
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

void PrintArray(int[] arr) // метод печати
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(Opposite(FillArray(10)));