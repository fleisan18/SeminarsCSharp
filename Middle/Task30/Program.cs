// 30.Показать кубы чисел, заканчивающихся на четную цифру

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

double[] Cube (double[] arr) // метод возведения элементов массива в куб
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Math.Pow(arr[i], 3);  
    }
    return arr;
}

double[] Even(double[] arr) //определяем, какие элементы заканчиваются на четную цифру
{
    int length = arr.Length;
    int count = 0;
    double[] b = new double [count];
    for (int i = 0; i < length; i++)
    {
        if(arr[i]%2==0) 
        {
            b[count] = arr[i];
            count++;
        }
    }
    return b;
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

double[] a = FillArray(15);
PrintArray(a);

PrintArray(Even(Cube(a)));