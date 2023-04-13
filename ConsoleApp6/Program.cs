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
Dictionary<int, int> counts = new Dictionary<int, int>();
for (int i = 0; i < matrix.GetLength(0); i += 2)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int element = matrix[i, j];
        if (!counts.ContainsKey(element))
        {
            counts[element] = 1;
        }
        else
        {
            counts[element]++;
        }
    }
}
Console.WriteLine("Количество одинаковых элементов на четных строках:");
foreach (KeyValuePair<int, int> count in counts)
{
    Console.WriteLine("{0}: {1}", count.Key, count.Value);
}
Console.ReadKey();