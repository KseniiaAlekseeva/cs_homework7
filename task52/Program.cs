// Create a two-dimensional array m*n with random integer numbers. 
// Find the arithmetic mean of elements in columns of array.

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[] GetColumn(int[,] array, int num)
{
    int[] col = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        col[i] = array[i, num];
    return col;
}

double Mean(int[] array)
{
    double mean = 0.0;
    for (int i = 0; i < array.Length; i++)
        mean += array[i];
    mean = mean / array.Length;
    return mean;
}

void MeanInColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int[] col = GetColumn(array, j);
        double mean = Mean(col);
        Console.WriteLine($"Column {j}: {mean}");
    }
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");
int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 9);
PrintArray(arr);
MeanInColumns(arr);



