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
Console.WriteLine("Введите элементы матрицы:");
for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(row[j]);
    }
}


int min = matrix[0, 0]; // предполагаем, что минимальный элемент это первый элемент
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (matrix[i, j] < min)
        { // если обнаружили элемент меньше предполагаемого минимального
            min = matrix[i, j]; // обновляем минимальный элемент
        }
    }
}

Console.WriteLine($"Наименьший элемент: {min}");
Console.WriteLine("Местоположение наименьшего элемента:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (matrix[i, j] == min)
        { // если элемент равен минимальному
            Console.WriteLine($"[{i}, {j}]"); // выводим его местоположение
        }
    }
}

Console.ReadKey();