Console.WriteLine("Введите M:");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];
Random rnd = new Random();

Console.WriteLine("Случайная матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rnd.Next(10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int sum = 0;
int min = matrix[0, 0], max = matrix[0, 0];

for (int i = 0; i < rows; i++)
{
    if (matrix[i, i] < min)
        min = matrix[i, i];
    if (matrix[i, i] > max)
        max = matrix[i, i];

    if (matrix[i, cols - i - 1] < min)
        min = matrix[i, cols - i - 1];
    if (matrix[i, cols - i - 1] > max)
        max = matrix[i, cols - i - 1];
}

sum = min + max;
Console.WriteLine($"Сумма минимального и максимального элементов диагоналей равна {sum}");