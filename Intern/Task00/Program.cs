// 0. Вывести квадрат числа

double SquareNum(double N) 
{ 
    return Math.Pow(N, 2); 
} 
double Num0 = new Random().Next(-50, 50);
Console.WriteLine($"Число {Num0} в квадрате = {SquareNum(Num0)}");



