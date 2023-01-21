// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
int square1 = number1 * number1;
int square2 = number2 * number2;
if (number1 == square2) Console.WriteLine("Первое число является квадратом второго");
else if (number2 == square1) Console.WriteLine("Второе число является квадратом первого");
else Console.WriteLine("Ни одно из чисел не является квадратого другого");