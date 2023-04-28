int[,] matrix = GetFillMatrix(3,4);
PrintMatrix(matrix);
Console.WriteLine();
int[,] result = SortMatrix(matrix);
PrintMatrix(result);

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

int[,] SortMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            for (int l = k + 1; l < matrix.GetLength(1); l++)
            {
                if (matrix[i, l] > matrix[i, k])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }

    return matrix;
}