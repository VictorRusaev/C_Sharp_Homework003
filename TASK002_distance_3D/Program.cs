Console.Clear();

Console.Write("Введите координату X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt((Math.Pow(X1 - X2, 2)) + (Math.Pow(Y1 - Y2, 2)) + (Math.Pow(Z1 - Z2, 2)));

Console.WriteLine($"Длина строки = {distance:f2}");