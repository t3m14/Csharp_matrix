int n, m;
Console.Write("Введите кол-во строк: ");
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Некорректный ввод, попробуйте еще раз.");
    Console.Write("Введите кол-во строк: ");
}
Console.Write("Введите кол-во столбцов: ");
while (!int.TryParse(Console.ReadLine(), out m))
{
    Console.WriteLine("Некорректный ввод, попробуйте еще раз.");
    Console.Write("Введите кол-во столбцов: ");
}
int[,] matrix = new int[n, m];
Random rnd = new Random();

Console.WriteLine("Случайная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rnd.Next(10);
        Console.Write(matrix[i, j] + " ");
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int sum = 0;
int min = matrix[0, 0], max = matrix[0, 0];

for (int i = 0; i < n; i++)
{
    if (matrix[i, i] < min)
        min = matrix[i, i];
    if (matrix[i, i] > max)
        max = matrix[i, i];

    if (matrix[i, m - i - 1] < min)
        min = matrix[i, m - i - 1];
    if (matrix[i, m - i - 1] > max)
        max = matrix[i, m - i - 1];
}

sum = min + max;
Console.WriteLine($"Сумма минимального и максимального элементов диагоналей равна {sum}");