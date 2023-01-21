// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine() ?? "0");
switch (day)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
}
if (day == 6 || day == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Рабочий");