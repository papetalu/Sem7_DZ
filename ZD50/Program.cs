// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
Console.Clear();
void InputMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = new Random().Next(-100, 101);
         Console.Write(matrix[i, j] + " \t");
      }
      Console.WriteLine();
   }
}


Console.Write("Введите кол-во строк таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine(" ");
Console.WriteLine("Введите номер строки и столбца искомого числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());


if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))
   Console.WriteLine("Искомое число: " + matrix[x - 1, y - 1]);
else Console.WriteLine("Нет такой позиции в таблице");
