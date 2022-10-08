// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
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
int[,] newMatrix = new int[m, n];
InputMatrix(matrix);

void NewConvertMatrix(int[,] newMatrix)
{
   for (int i = 0; i < newMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < newMatrix.GetLength(1); j++)
      {
         newMatrix[i, j] = matrix[j, i];
         //Console.Write(newMatrix[i, j] + " \t");
      }
      //Console.WriteLine();
   }
}

NewConvertMatrix(newMatrix);
Console.WriteLine(" ");

double[] array = new double[m];

void InputArray(double[] array)
{

   for (int i = 0; i < array.Length; i++)
   {
      double sum = 0;
      for (int j = 0; j < newMatrix.GetLength(1); j++)
      {
         sum = sum + newMatrix[i, j];
      }
      array[i] = Math.Round(sum / newMatrix.GetLength(1), 3);
   }

}
InputArray(array);
Console.WriteLine($"Среднее арифметическое столбцов: [{string.Join("; ", array)}]");


