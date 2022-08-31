/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
1 строка
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
            matrix[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintMatrix(double[,] matrix)
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
PrintMatrix(matrix);

double SumLineElements(double[,] matrix, int i)
{
    double SumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        SumLine += matrix[i, j];
    }
    System.Console.WriteLine($"Сумма элементов {i + 1}-ой строки {SumLine}");
    return SumLine;
}

double SumLineMin = 0;
double SumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    double ResSumLine = SumLineElements(matrix, i);
    if (SumLine > ResSumLine)
    {
        SumLine = ResSumLine;
        SumLineMin = i;
    }
}

Console.WriteLine($"\n{SumLineMin + 1}-я строкa с наименьшей суммой элементов ({SumLine})");
