// Create a two-dimensional array m*n with random real numbers.

double[,] CreateArray(int m, int n, double minValue, double maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

double[,] arr = CreateArray(m, n, -9.9, 9.9);
PrintArray(arr);




