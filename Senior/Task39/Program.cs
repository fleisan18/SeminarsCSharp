// 39.Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] FillArray(int count) // заполняем массив
{
    int[] arr = new int [count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-50,50);
    }
    return arr;
}


int[] Square (int[] a) // метод для расчета произведений пар чисел
{
    int length = a.Length;
    int[] b = new int [length/2];
    for (int i = 0; i < length/2; i++)
    {
        b[i] = a[i] * a[length-i-1];
    }
    return b;
}

void PrintArray(int[] arr) // метод печати
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = FillArray(10);
PrintArray(array);

PrintArray(Square(array));