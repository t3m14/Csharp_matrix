using System.Numerics;

Console.WriteLine("Введите N");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int n = Convert.ToInt32(Console.ReadLine());
int k;
Console.Write("Введите число K: ");
k = int.Parse(Console.ReadLine());

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
int sum = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i + j == k)
        { // проверяем индексы элемента
            sum += matrix[i, j]; // добавляем его значение к сумме
        }
    }
}

Console.WriteLine("Сумма элементов матрицы, индексы которых составляют в сумме число {0}: {1}", k, sum);
Console.ReadKey();