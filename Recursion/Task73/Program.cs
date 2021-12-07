// 73. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

string SumOfNumbers(int number1, int number2, int n)
{
    if (n == 1) return $"{number1}";
    else return $"{number1}, {SumOfNumbers(number2, number2+number1, n-1)}";
}

System.Console.WriteLine(SumOfNumbers(3,4,10));
