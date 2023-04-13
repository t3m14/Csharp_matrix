using System;

class Program
{
    static void Main()
    {
        int rows, cols,
            maxValue = int.MinValue, // максимальное значение, изначально установлено на самое низкое возможное число
            maxRow = 0, // номер строки с максимальным элементом
            maxCol = 0; // номер столбца с максимальным элементом

        Console.Write("Введите количество строк матрицы: ");
        while (!int.TryParse(Console.ReadLine(), out rows))
        {
            Console.WriteLine("Некорректный ввод. Введите число строк.");
        }

        Console.Write("Введите количество столбцов матрицы: ");
        while (!int.TryParse(Console.ReadLine(), out cols))
        {
            Console.WriteLine("Некорректный ввод. Введите число столбцов.");
        }

        int[,] matrix = new int[rows, cols]; // создаем матрицу

        for (int i = 0; i < rows; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }


        // выводим информацию о максимальном элементе
        Console.WriteLine("Максимальный элемент матрицы: {0}", maxValue);
        Console.WriteLine("Номер строки: {0}", maxRow);
        Console.WriteLine("Номер столбца: {0}", maxCol);
    }
}