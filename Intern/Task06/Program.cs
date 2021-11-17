// 6. Выяснить является ли число чётным

bool NumisEven(int Na)
{ return Na % 2 == 0; }
int a6 = new Random().Next(-50,50);
Console.WriteLine($"Число чётное {a6}? Ответ: {NumisEven(a6)}");
