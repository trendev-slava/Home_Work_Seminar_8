int[,] qwe = GetFillMatrix(2, 2);
int[,] ewq = GetFillMatrix(2, 2);
PrintMatrix(qwe);
PrintMatrix(ewq);
int[,] res = MatrixMultiplication(qwe, ewq);
PrintMatrix(res);




int[,] GetFillMatrix(int line, int collumn)
{
    int[,] matrix = new int[line, collumn];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 5);

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
    Console.WriteLine();
}

int[] MatrixToArray(int[,] matrix)
{
    int size = matrix.GetLength(0) * matrix.GetLength(1);
    int[] numbers = new int[size];
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            numbers[index] = matrix[i, j];
            if (index < 10)
                index++;
            else return numbers;
        }

    }
    return numbers;
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{

    int[,] newMatrix = new int[array1.GetLength(0), array1.GetLength(0)];
    int res = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int n = 0;
            
            while (n < newMatrix.GetLength(0) )
            {
                res += (array1[i, n] * array2[n, j]);
                n++;
                
            }
            newMatrix[i, j] = res;
            res = 0;

        }
    }
    return newMatrix;

}