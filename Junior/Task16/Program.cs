﻿//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
int a16 = new Random().Next(1,8);
bool Holiday(int a)
{
    return a>=6;
}
Console.WriteLine($"Является ли {a16} день недели выходным? {Holiday(a16)}");
