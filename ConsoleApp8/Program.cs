Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
Random random = new Random();

Console.WriteLine("Сгенерированная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.Next(10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int rowNumber = int.Parse(Console.ReadLine()) - 1;

int sumDiagonal = 0;
for (int i = 0; i < n; i++)
    sumDiagonal += matrix[i, i];

int sumRow = 0;
for (int j = 0; j < n; j++)
    sumRow += matrix[rowNumber, j];

int result = sumDiagonal * sumRow;
Console.WriteLine("Произведение суммы элементов главной диагонали и суммы элементов {0}-ой строки равно {1}", rowNumber + 1, result);

Console.ReadKey();