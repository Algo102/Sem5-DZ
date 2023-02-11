// вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
double ReadInt(string message)
{
  Console.Write(message);
  return double.Parse(Console.ReadLine()!);
}

Console.Clear();
Console.Write("Введите четыре координаты (8 цифр) ЧЕРЕЗ ПРОБЕЛ ");
string enterElem = Console.ReadLine()!;
string[] word = enterElem.Split(' ')!;

double[] arrEnt = new double[word.Length];

for (int i = 0; i < word.Length; i++)
{
  string sum = word[i].Trim();
  arrEnt[i] = Convert.ToInt32(sum) !;
}
Console.Write("Ваши введенные координаты четырех вершин ");
Console.Write($"({arrEnt[0]},{arrEnt[1]}) ({arrEnt[2]},{arrEnt[3]}) ({arrEnt[4]},{arrEnt[5]}) ({arrEnt[6]},{arrEnt[7]})\n");

double x = ReadInt("Введите коэффициент масштабирования фигуры ");

for (int i = 0; i < word.Length; i++)
{
    arrEnt[i] *= x;
}
Console.Write("Новые координаты после масштабирования ");
Console.Write($"({arrEnt[0]},{arrEnt[1]}) ({arrEnt[2]},{arrEnt[3]}) ({arrEnt[4]},{arrEnt[5]}) ({arrEnt[6]},{arrEnt[7]})");
