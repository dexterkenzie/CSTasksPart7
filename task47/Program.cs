// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] numbersMatrix = new double[m, n];
FillArrayRandomNumbers(numbersMatrix);
PrintArray(numbersMatrix);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-99, 100));
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} "); // 4 - количество символов, которое занимает каждое число; выравнивание печати массива
        }
        Console.WriteLine("");
    }
}

Console.WriteLine();