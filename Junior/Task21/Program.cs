//21. Программа проверяет пятизначное число на палиндром.
int a = new Random().Next(10000,100000);
bool Palindrom(int a)
{
    int n = a%10*10+(a%100)/10;
    return (a/1000==a%10*10+a%100/10);
}
Console.WriteLine($"{a} - палиндром? - {Palindrom(a)}");

//22. Найти расстояние между точками в пространстве 2D/3D
//2D 
// int X1 = new Random().Next(-50,50);
// int Y1 = new Random().Next(-50,50);
// int X2 = new Random().Next(-50,50);
// int Y2 = new Random().Next(-50,50);

// double Distance(int x1, int y1, int x2, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2));
//     return distance;
// }
// Console.WriteLine($"Расстояние между точками с координатами ({X1},{Y1}) и ({X2},{Y2}) в 2D равно {Distance(X1, Y1, X2, Y2)}");

//3D 
int X1 = new Random().Next(-50,50);
int Y1 = new Random().Next(-50,50);
int Z1 = new Random().Next(-50,50);
int X2 = new Random().Next(-50,50);
int Y2 = new Random().Next(-50,50);
int Z2 = new Random().Next(-50,50);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2));
    return distance;
}
Console.WriteLine($"Расстояние между точками с координатами ({X1},{Y1},{Z1}) и ({X2},{Y2},{Z2}) в 2D равно {Distance(X1, Y1,Z1, X2, Y2,Z2)}"); 
