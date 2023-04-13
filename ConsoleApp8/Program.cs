using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество строк в матрице:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов в матрице:");
                int m = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, m];

                Random random = new Random();

                Console.WriteLine($"Матрица {n}x{m}:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = random.Next(-10, 11); // заполняем матрицу случайными числами от -10 до 10
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Выберите строку для вычисления произведения:");
                int row = int.Parse(Console.ReadLine()) - 1; // вычитаем 1, так как в программировании индексация начинается с 0

                int sumOfDiagonal = 0;
                int sumOfRow = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i == j) // если элемент на главной диагонали
                        {
                            sumOfDiagonal += matrix[i, j]; // добавляем его значение к сумме главной диагонали
                        }
                        if (i == row) // если элемент на выбранной пользователем строке
                        {
                            sumOfRow += matrix[i, j]; // добавляем его значение к сумме элементов в строке
                        }
                    }
                }

                Console.WriteLine($"Произведение суммы элементов главной диагонали ({sumOfDiagonal}) на сумму элементов {row + 1}-ой строки ({sumOfRow}):");
                int multiplication = sumOfDiagonal * sumOfRow;
                Console.WriteLine(multiplication);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка ввода. " + e.Message);
            }
        }
    }
}