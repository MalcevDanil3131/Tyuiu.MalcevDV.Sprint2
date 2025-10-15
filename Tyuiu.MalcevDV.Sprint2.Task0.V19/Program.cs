using Tyuiu.MalcevDV.Sprint2.Task0.V19.Lib;
DataService ds = new DataService();
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #2", width);
PrintCenteredLine("Тема: Создание решения по таску", width);
PrintCenteredLine("Задание #0", width);
PrintCenteredLine("Вариант #19", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, вычисляющую значения логических выражений", width);
PrintCenteredLine("используя две переменные", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ: x = 105, y = 177", width);
int x = 105;
int y = 177;
bool [] res = new bool[6];
res = ds.GetCompareOperations(x, y);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
for (int i = 0; i < 6; i++)
{
    PrintCenteredLine($"{res[i]}", width);
}
Console.WriteLine(new string('*', width));