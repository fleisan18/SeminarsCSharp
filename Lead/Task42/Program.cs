// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите числа"); //разделитель - ','
string word = Console.ReadLine();

string IsNumber(string a) //выцепляем все числа
{
    int length = a.Length;
    string newAlph = string.Empty;

    for (int i = 0; i < length; i++)
    {
        if(a[i]==44||a[i]==45||(a[i]>=48&&a[i]<=57)) newAlph = newAlph + a[i];
    }
    return newAlph;
}


int[] toInt(string[] a) //преобразуем в массив целых чисел
{
    int length = a.Length;
    int[] b = new int[length];
    for (int i = 0; i < length; i++)
    {
        b[i] = int.Parse(a[i]);
    }
    return b;
}

int Bigger0(int[] a) //считаем, какие числа больше 0
{
    int length = a.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(a[i]>0) count++;
    }
    return count;
}
string b = IsNumber(word);
string[] alph = b.Split(',');
System.Console.WriteLine(b);

int[] array = toInt(alph);
int number = Bigger0(array);
Console.WriteLine(number);
