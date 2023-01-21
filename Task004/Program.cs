// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
Console.WriteLine("Выберите нужный пункт (1 или 2): ");

int selection = int.Parse(Console.ReadLine() ?? "0");
switch (selection)
{
    case 1:
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    double distance = Math.Sqrt((x2 - x1)*(x2-x1) + (y2 - y1)*(y2-y1));
    Console.WriteLine("Расстояние между двумя точками на плоскости =" + distance);
    break;
    case 2:
    Console.Write("Введите координаты x1: ");
    x1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты x2: ");
    x2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты y1: ");
    y1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты y2: ");
    y2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.Write("Введите координаты z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    Console.WriteLine("Расстояние между двумя точками в пространстве ="+ distance);
    break;
    default:
    Console.WriteLine("Вы ввели неверный символ");
    break;
}