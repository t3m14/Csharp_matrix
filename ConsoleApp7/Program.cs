try
{
    Console.Write("Введите размерность квадратной матрицы: ");
    int n = int.Parse(Console.ReadLine());

    int m = n;

    int[,] matrix = new int[n, m];
    Console.WriteLine("Введите элементы матрицы:");
    for (int i = 0; i < n; i++)
    {
        string[] row = Console.ReadLine().Split(' ');
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = int.Parse(row[j]);
        }
    }


    Console.WriteLine("Матрица:");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    double maxDiagonal = matrix[0, 0];
    for (int i = 0; i < n; i++)
    {
        if (matrix[i, i] > maxDiagonal)
        {
            maxDiagonal = matrix[i, i];
        }
    }

    Console.WriteLine("Средние значения элементов в каждой строке:");
    for (int i = 0; i < n; i++)
    {
        double sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += matrix[i, j];
        }
        double average = sum / n;
        Console.WriteLine($"Среднее арифметическое в строке {i}: {average}");
        if (average > maxDiagonal)
        {
            Console.WriteLine($"Среднее арифметическое в строке {i} больше максимального элемента на главной диагонали ({maxDiagonal})");
        } 
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Ошибка формата ввода. Введите число.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}