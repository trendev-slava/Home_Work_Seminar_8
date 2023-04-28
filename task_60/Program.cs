int[,,] qwe = GetFill3Darray(2,2,2);
PrintArray3D(qwe);

int NumberRandom(int number)
{
    int res = new Random().Next(10, 100);
    if (res == number)
    {
    return res;
    }
    else return NumberRandom(res);
}

int[,,] GetFill3Darray(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];

    int number = 0;
    int secNumber = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                number = NumberRandom(secNumber);
                array3D[i,j,k] = number;
                
            }
        }
    }
    return array3D;
}
void PrintArray3D(int[,,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
       
           for (int z = 0; z < array.GetLength(2); z++)
           {
            Console.Write($"{array[i,j,z]} ({i},{j},{z}) ");
           }
          
        }
        Console.WriteLine();
    }
}