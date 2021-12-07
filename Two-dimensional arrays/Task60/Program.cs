// 60. Составить частотный словарь элементов двумерного массива
//1
int[,] CreateArray(int m, int n)
{
    return new int[m, n];
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int CountOfNumbers(int[,] array, int temp)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == temp) count++;
        }
    }
    return count;
}

bool CheckedItems(int[,] array, int temp, bool here = false)
{
    int length = array.Length;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == temp) { here = true; break; }  
        }
    }
    return here;
}

string FrequencyDictionary(int[,] array)
{
    string result = string.Empty;
    int[,] checkedNumbers = new int [array.GetLength(0), array.GetLength(1)];
    bool wasChecked = false;
    int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                wasChecked = CheckedItems(checkedNumbers, array[i, j]);
                if (wasChecked != true)
                {
                    temp = CountOfNumbers(array, array[i, j]);
                    result += $"{array[i, j]} встретился {temp} раз|";
                    checkedNumbers[i,j] = temp;
                }
            }
        }
    return result;
}

void PrintTwoDimentionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] array60 = FillArray(CreateArray(4, 3));
PrintTwoDimentionalArray(array60);

string frequency = FrequencyDictionary(array60);
System.Console.WriteLine(frequency);

//2

Dictionary<int, int> doc = new();

for (int i = 0; i < array60.GetLength(0); i++)
{
    for (int j = 0; j < array60.GetLength(1); j++)
    {
        if (!doc.ContainsKey(array60[i, j])) doc.Add(array60[i, j], 1);
        else doc[array60[i, j]]++;
    }
}

foreach (var item in doc)
{
    System.Console.WriteLine(item);
}
