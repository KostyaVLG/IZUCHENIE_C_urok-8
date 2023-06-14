// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задайте размер матриц");

Console.Write("Введите число строк 1-й матрицы: ");   
int rowsFirstMartrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int columnsFirstMartrixRowsSecomdMartrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 2-й матрицы: ");
int columnsSecomdMartrix = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[rowsFirstMartrix, columnsFirstMartrixRowsSecomdMartrix];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[columnsFirstMartrixRowsSecomdMartrix, columnsSecomdMartrix];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[rowsFirstMartrix,columnsSecomdMartrix];

MultiplicationMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplicationMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,15);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}