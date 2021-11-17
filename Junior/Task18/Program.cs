//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool TrueorFalse(bool x, bool y)
{
    return (!(x || y))==(!x && !y);
}

int x = new Random().Next(0,2);
int y = new Random().Next(0,2);

bool X = Convert.ToBoolean(x);
bool Y = Convert.ToBoolean(y);

Console.WriteLine($"X = {X},Y = {Y}; {TrueorFalse(X, Y)}");