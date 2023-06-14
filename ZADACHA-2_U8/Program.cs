// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("введите количество строк (не мение двух): ");   
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите количество столбцов (не мение двух): ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows<2 && columns<2)
{
    Console.WriteLine("Недопустимое значение матрици");
    return;
}
int[,] resMatrix = new int[rows, columns];  // создаю переменную дл нового массива
FillArrayRandomNumbers(resMatrix);          //вызов создания массива
Console.Write("По вашим параметрам создана матрица: ");
Console.WriteLine();
Console.WriteLine();
PrintArray(resMatrix);  //вызов печати массива (печатает исходный массив)

int minIndex = SearchMinIndex(resMatrix); //вызов метода сортировки строки
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой чисел: {minIndex + 1}");


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

int SearchMinIndex(int[,] resMatrix)
{
    int index = 0;
    int min = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            if (i==0)
                min = min + resMatrix[i,j];
            else
                sum = sum + resMatrix[i,j];
        }

        if (i==0)
        {
            index = i;
        }
        else if (min>=sum)
        {
            min = sum;
            index = i;  
        }
    }

    return index;
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