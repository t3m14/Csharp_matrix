using System.Numerics;

Console.WriteLine("Введите N");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] matrix = new int[n, m];
for (int i = 0; i < n; i++)
{
    string row_text = Console.ReadLine();
    if (row_text != null && row_text.Length > 0)
    {
        string[] row = row_text.Split(" ");
        if (row.Length == m)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(row[j]);
            }

        }
    }
}
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);
int maxDiag = int.MinValue;
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
        if (i == j && matrix[i, j] > maxDiag)
        {
            maxDiag = matrix[i, j];
        }
        sum += matrix[i, j];
    }
    double avg = (double)sum / cols;
    Console.WriteLine("Среднее арифметическое в строке {0}: {1}", i + 1, avg);
}
Console.WriteLine("Максимальное значение элементов главной диагонали: {0}", maxDiag);

for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
        sum += matrix[i, j];
    }
    double avg = (double)sum / cols;
    if (avg > maxDiag)
    {
        Console.WriteLine("Среднее арифметическое в строке {0} больше максимального значения элементов главной диагонали", i + 1);
    }
}
}
Console.ReadKey();