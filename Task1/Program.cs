/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void FillMatrix(double[,] matrix)
{
    double row = matrix.GetLength(0);
    double column = matrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-9, 10);
        }
    }
}

void PrintMatrix1(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

void SortInDescendingOrder(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    double temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

void PrintMatrix2(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

int m = Prompt($"Введите высоту массива >");
int n = Prompt($"Введите длину массива >");
double[,] matrix = new double[m, n];

FillMatrix(matrix);
System.Console.WriteLine("");
PrintMatrix1(matrix);
SortInDescendingOrder(matrix);
System.Console.WriteLine("");
PrintMatrix2(matrix);
