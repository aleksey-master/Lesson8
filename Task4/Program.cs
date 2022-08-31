/* Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int m = Prompt($"Введите размер массива >");
int[,] spiralmatrix = new int[m, m];

int res = 1;
int i = 0;
int j = 0;

while (res <= spiralmatrix.GetLength(0) * spiralmatrix.GetLength(1))
{
    spiralmatrix[i, j] = res;
    res++;
    if (i <= j + 1 && i + j < spiralmatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralmatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralmatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintSpiralMatrix(int[,] spiralmatrix)
{
    for (int i = 0; i < spiralmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < spiralmatrix.GetLength(1); j++)
        {
            if (spiralmatrix[i, j] / 10 <= 0)
                Console.Write($" {spiralmatrix[i, j]} ");
            else
                Console.Write($"{spiralmatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintSpiralMatrix(spiralmatrix);
