using System.Numerics;

Console.WriteLine("Введите N");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int n = Convert.ToInt32(Console.ReadLine());
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
List<int> duplicates = new List<int>();

for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    for (int j = i + 1; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, k] == matrix[j, k] && !duplicates.Contains(matrix[i, k]))
            {
                duplicates.Add(matrix[i, k]);
            }
        }
    }
}
foreach (int duplicate in duplicates)
{
    Console.WriteLine(duplicate);
}

Console.ReadKey();