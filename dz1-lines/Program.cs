Console.WriteLine("Программа для поиска точки пересечения двух прямых");
Console.WriteLine("y1 = k1 * x + b1");
double ReadInt(string message)
{
  Console.WriteLine(message);
  return double.Parse(Console.ReadLine()!);
}

double k1 = ReadInt("Введите k1 первой линии");
double b1 = ReadInt("Введите b1 первой линии");

double k2 = ReadInt("Введите k2 первой линии");
double b2 = ReadInt("Введите b2 первой линии");

double x = (b2-b1)/(k1-k2);

double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых. Координата по Х = {x}, по Y = {y2}");