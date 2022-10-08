// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных
// числа N и M – количество строк и столбцов матрицы. 
//В каждой из последующих N строк записаны M целых чисел – 
//элементы матрицы. Все числа во входных данных не превышают 
//100 по абсолютной величине.
Console.Clear();
void InputMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = new Random().Next(1, 101);
         Console.Write(matrix[i, j] + " \t");
      }
      Console.WriteLine();
   }
}


void ReleaseMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0) / 2; i++)
   {

      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         int tmp = 0;
         tmp = matrix[i, j];
         matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
         matrix[matrix.GetLength(0) - i - 1, j] = tmp;

      }
   }
}

void PrintMatrix(int[,] matrix)
{
   Console.WriteLine();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
         Console.Write(matrix[i, j] + " \t");
      Console.WriteLine();
   }
}

Console.Write("Введите кол-во строк таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
ReleaseMatrix(matrix);
PrintMatrix(matrix);

