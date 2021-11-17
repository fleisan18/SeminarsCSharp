//21. Программа проверяет пятизначное число на палиндром.
int a = new Random().Next(10000,100000);
int b = 12321;
bool Palindrom(int a)
{
    return (a/1000==a%10*10+a%100/10);
}
Console.WriteLine($"{a} - палиндром? - {Palindrom(a)}");
Console.WriteLine($"{b} - палиндром? - {Palindrom(b)}");

