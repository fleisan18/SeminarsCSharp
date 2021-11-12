//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x18 = true;
bool y18 = false;
bool TrueorFalse(bool x, bool y)
{
    return (!(x || y))==(!x && !y);
}
Console.WriteLine(TrueorFalse(x18, y18));
