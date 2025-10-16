using Tyuiu.MalcevDV.Sprint2.Task2.V19.Lib;
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
PrintCenteredLine("Задание #2", width);
PrintCenteredLine("Вариант #19", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, проверяющую является ли клетка закрашена", width);
PrintCenteredLine("исходя из рисунка", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine("Введите x:", width);
var x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y:", width);
var y = int.Parse(Console.ReadLine());
var res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));