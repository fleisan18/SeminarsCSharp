// 47. Написать программу копирования массива
int[] CreateArray(int count) //создаем массив
{
    int[] array = new int [count];
    return array;
}
int[] FillArray(int[] a) //заполняем массив
{
    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(0,100);
    }
    return a;
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
int[] a = FillArray(CreateArray(10));
PrintArray(a);

int[] b = new int [10]; 
Array.Copy(a, b, 10);
PrintArray(b);
