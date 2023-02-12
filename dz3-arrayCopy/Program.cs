int[] GreateRandArr(int lenght, int low, int hi)
{
  Random random = new Random();
  int[] array = new int[lenght];
  for (int i = 0; i<array.Length; i++)
    array[i] = random.Next(low, hi+1);
  return array;
}

void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
  Console.WriteLine();
}

int[] massive1 = GreateRandArr(10, 1 , 20);
int[] massive2 = GreateRandArr(15, 1 , 20);
PrintArray(massive1);
PrintArray(massive2);

// Console.WriteLine("Введите имя массива - который вы хотите скопировать");
// string newMassive = Console.ReadLine()!;
// Console.WriteLine(newMassive);

// int[] newArray = new int[newMassive.Length];
// for(int i = 0; i < newArray.Length; i++)
//   newArray[i] = newMassive[i];

//PrintArray(newArray);


int[] arrEnt = new int[massive1.Length];
for (int i = 0; i < massive1.Length; i++)
  arrEnt[i] = massive1[i];

PrintArray(arrEnt);
