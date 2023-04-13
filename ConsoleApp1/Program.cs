using System.Numerics;

Console.WriteLine("Введите N");
int  m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[n, m];
for (int i = 0; i < n; i++)
{
    string row_text = Console.ReadLine();
    if (row_text != null && row_text.Length > 0)
    {
        string[] row = row_text.Split(" ");
        if (row.Length == m)
        {
            for(int j = 0; j < m; j++)
            {
                matr[i, j] = Convert.ToInt32(row[j]);
            }

        }
    }
}
int lowest = 999999999;
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        if (matr[i, j] < lowest)
        {
            lowest = matr[i, j];
        }
    }
}
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        if (matr[i, j] == lowest)
        {
            Console.WriteLine();
            Console.Write("x: ");
            Console.Write(j + 1);
            Console.Write(" ");
            Console.Write("y: ");
            Console.Write(i + 1);
            Console.WriteLine();
        }
    }
}
Console.ReadKey();