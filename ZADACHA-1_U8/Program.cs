// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("введите количество строк: ");   
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows==0 && columns==0)
{
    Console.WriteLine("Недопустимое значение матрици");
    return;
}
int[,] resMatrix = new int[rows, columns];  // создаю переменную дл нового массива
FillArrayRandomNumbers(resMatrix);          //вызов создания массива

Console.Write("Исходная матрица: ");
Console.WriteLine();

PrintArray(resMatrix);  //вызов печати массива (печатает исходный массив)

SortDescending(resMatrix); //вызов метода сортировки массива
Console.WriteLine("Сортировка по убыванию:");
PrintArray(resMatrix);  //вызов печати массива (печатает ОТСОРТИРОВАННЫЙ массив)
    
void FillArrayRandomNumbers(int[,] array) // Метод создания массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
        }

}

void SortDescending(int[,] resMatrix) // Метод сортировки массива
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for (int row = j; row < resMatrix.GetLength(1); row++)
            {
                if (resMatrix[i, j] < resMatrix[i, row])
                {
                    int temp = resMatrix[i, row];
                    resMatrix[i, row] = resMatrix[i, j];
                    resMatrix[i, j] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)                                       // Метод, который печатает массив 
{
    for (int i = 0; i < array.GetLength(0); i++)             // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++)        // столбцы
        {
            Console.Write(array[i,j] + "\t");                    // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine();
    }
}