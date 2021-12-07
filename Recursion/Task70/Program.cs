// 70. Найти сумму цифр числа
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    if (number / 10 == 0) return number;
    else return number%10 + Sum(number / 10);
}
System.Console.WriteLine(Sum(number));
