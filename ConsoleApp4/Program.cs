using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос ввода количества строк и столбцов матрицы
        Console.WriteLine("Введите количество строк матрицы:");
        int n = int.Parse(Console.ReadLine()); // Преобразуем введенную строку в число
        Console.WriteLine("Введите количество столбцов матрицы:");
        int m = int.Parse(Console.ReadLine()); // Преобразуем введенную строку в число

        // Создание двумерного массива заданного размера и заполнение его числами, введенными с клавиатуры
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


        // Поиск максимального четного элемента матрицы
        int max = int.MinValue; // Задаем начальное значение максимального элемента
        int rowMax = 0; // Строка, в которой находится максимальный элемент
        int colMax = 0; // Столбец, в котором находится максимальный элемент
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] % 2 == 0 && matrix[i, j] > max) // Поиск максимального четного элемента матрицы
                {
                    max = matrix[i, j];
                    rowMax = i;
                    colMax = j;
                }
            }
        }

        // Вывод результата
        if (max != int.MinValue) // Проверка на наличие четных элементов
        {
            Console.WriteLine($"Максимальный четный элемент матрицы: {max}"); // Вывод максимального четного элемента
            Console.WriteLine($"Номер строки: {rowMax + 1}"); // Вывод номера строки, в которой находится максимальный элемент
            Console.WriteLine($"Номер столбца: {colMax + 1}"); // Вывод номера столбца, в котором находится максимальный элемент
        }
        else // Если четных элементов в матрице нет
        {
            Console.WriteLine("Четных элементов в матрице нет.");
        }

        Console.ReadLine(); // Задержка консоли
    }
}