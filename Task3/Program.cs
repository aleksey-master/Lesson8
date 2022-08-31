/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void FillFirstMatrix(double[,] firstmatrix)
{
    int Range = Prompt($"Введите диапазон случайных чисел 1-ой матрицы >");
    double row = firstmatrix.GetLength(0);
    double column = firstmatrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstmatrix.GetLength(1); j++)
        {
            firstmatrix[i, j] = rand.Next(Range);
        }
    }
}

void PrintFirstMatrix(double[,] firstmatrix)
{
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstmatrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", firstmatrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

void FillSecondMatrix(double[,] secondmatrix)
{
    int Range = Prompt($"Введите диапазон случайных чисел 2-ой матрицы >");
    double row = secondmatrix.GetLength(0);
    double column = secondmatrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < secondmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            secondmatrix[i, j] = rand.Next(Range);
        }
    }
}

void PrintSecondMatrix(double[,] secondmatrix)
{
    for (int i = 0; i < secondmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", secondmatrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

void MultipliedMatrix(double[,] firstmatrix, double[,] secondmatrix, double[,] thirdmatrix)
{
    for (int i = 0; i < thirdmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdmatrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int k = 0; k < firstmatrix.GetLength(1); k++)
            {
                sum += firstmatrix[i, k] * secondmatrix[k, j];
            }
            thirdmatrix[i, j] = sum;
        }
    }
}

void PrintThirdMatrix(double[,] thirdmatrix)
{
    for (int i = 0; i < thirdmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdmatrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", thirdmatrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

int m = Prompt($"Введите высоту массива 1-ой матрицы >");
int n = Prompt($"Введите длину массива 1-ой матрицы (высоту массива 2-ой матрицы) >");
int k = Prompt($"Введите длину массива 2-ой матрицы >");
double[,] firstmatrix = new double[m, n];
double[,] secondmatrix = new double[n, k];
double[,] thirdmatrix = new double[m, k];

FillFirstMatrix(firstmatrix);
System.Console.WriteLine("");
FillSecondMatrix(secondmatrix);
System.Console.WriteLine("");
PrintFirstMatrix(firstmatrix);
System.Console.WriteLine("");
PrintSecondMatrix(secondmatrix);
System.Console.WriteLine("");
MultipliedMatrix(firstmatrix, secondmatrix, thirdmatrix);
Console.WriteLine($"Произведение матриц:");
PrintThirdMatrix(thirdmatrix);
