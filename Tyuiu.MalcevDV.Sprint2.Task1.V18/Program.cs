using Tyuiu.MalcevDV.Sprint2.Task1.V18.Lib;
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
PrintCenteredLine("Задание #1", width);
PrintCenteredLine("Вариант #18", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, вычисляющую значения логических операций", width);
PrintCenteredLine("используя четыре переменные", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ: a = 155, b = 696, c = 242, d = 541", width);
int a = 155;
int b = 696;
int c = 242;
int d = 541;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b ,c, d);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
for (int i = 0; i < 6; i++)
{
    PrintCenteredLine($"{res[i]}", width);
}
Console.WriteLine(new string('*', width));
