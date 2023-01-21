// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти (1,2,3,4): ");
int q = int.Parse(Console.ReadLine() ?? "0");
while (q<1 || q>4)
{
    Console.Write("Ошибка ввода. Введите номер четверти (1,2,3,4): ");
    q = int.Parse(Console.ReadLine() ?? "0");
}
switch (q)
{
    case 1: Console.WriteLine("Диапазон координат: X>0, Y>0."); break;
    case 2: Console.WriteLine("Диапазон координат: X<0, Y>0."); break;
    case 3: Console.WriteLine("Диапазон координат: X<0, Y<0."); break;
    case 4: Console.WriteLine("Диапазон координат: X>0, Y<0."); break;
}