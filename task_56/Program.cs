int[,] matrix = GetFillMatrix(5, 2);
PrintMatrix(matrix);
int res = SearchLineOfMinimumSum(matrix);
Console.WriteLine(res);



int[,] GetFillMatrix(int line, int collumn)
{
    int[,] matrix = new int[line, collumn];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j]}| ");
        }
        Console.WriteLine();
    }
}

int SearchLineOfMinimumSum(int[,] matrix)
{
    int line = 1;
    int sum1 = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        sum1 += matrix[0, i];

    int min = sum1;

    for (int j = 1; j < matrix.GetLength(0); j++)
    {
        sum1 = 0;

        for (int k = 0; k < matrix.GetLength(1); k++)
            sum1 += matrix[j, k];

        if (sum1 < min)
        {
            min = sum1;
            line = j + 1;
        }
    }
    return line;
}