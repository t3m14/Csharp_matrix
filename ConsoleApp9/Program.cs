// Пользователь вводит размеры матрицы
Console.WriteLine("Введите количество строк матрицы:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int m = int.Parse(Console.ReadLine());

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

// Пользователь вводит значение K
Console.WriteLine("Введите значение K:");
int k = int.Parse(Console.ReadLine());

int sum = 0;

// Перебираем все элементы матрицы
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        // Если сумма индексов равна K, добавляем значение элемента в сумму
        if (i + j == k)
        {
            sum += matrix[i, j];
        }
    }
}

// Выводим результат
Console.WriteLine($"Сумма элементов матрицы, индексы которых составляют в сумме {k} равна {sum}");