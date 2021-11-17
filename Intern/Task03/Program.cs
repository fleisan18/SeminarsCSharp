// 3. По заданному номеру дня недели вывести его название

string DayWeekName (int daynumber)
{
 string[] Dayweek = {"Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресение"};
 return Dayweek[daynumber-1];
}
int daynumber = new Random().Next(1,8);
Console.WriteLine($"{daynumber} день недели  = {DayWeekName(daynumber)}");
