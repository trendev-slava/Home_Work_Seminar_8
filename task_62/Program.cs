int[,] matrix = GetFillMatrixSpiral(4,4);
Print(matrix);




int[,] GetFillMatrixSpiral(int line, int collumn)
{
    int[,] matrix = new int[line, collumn];
    int number = 0;
    for (int j = 0; j < 4; j++)
    {
        matrix[0,j] = number;
        number++;
    }
    for (int i = 1; i < 4; i++)
    {
        matrix[i,3] = number;
        number++;
    }
    for (int k = 2; k >= 0; k--)
    {
        matrix[3,k] = number;
        number++;
    }
    for (int l = 2; l >= 1; l--)
    {
        matrix[l,0] = number;
        number++;
    }
     for (int m = 1; m <= 2; m++)
    {
        matrix[1,m] = number;
        number++;
    }
        matrix[2,2] = number;
        number++;
        matrix[2,1] = number;
    
   
    return matrix;
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}


