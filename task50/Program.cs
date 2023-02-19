// Create a two-dimensional array m*n with random integer numbers. Function returns the element by the specified indexes 
// or reports that there is no element with these indexes in this array.

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

int GetElement(int[,] array, int i, int j)
{
    int res = 0;
    if ((i < array.GetLength(0)) && (j < array.GetLength(1)))
    {
        res = array[i, j];
        Console.WriteLine($"The element of array with indexes [{i},{j}] is {res}.");
    }
    else
        Console.WriteLine($"There is no element with indexes [{i},{j}] in array.");
    return res;
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");
int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, -20, 20);
PrintArray(arr);

Console.WriteLine("Enter the indexes i, j of the element: ");
str = Console.ReadLine().Split(" ");
int i = Convert.ToInt32(str[0]);
int j = Convert.ToInt32(str[1]);
int res = GetElement(arr, i, j);




