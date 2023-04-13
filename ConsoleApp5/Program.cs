using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество строк в матрице: ");
        int n = int.Parse(Console.ReadLine()); //ввод количества строк матрицы
        Console.Write("Введите количество столбцов в матрице: ");
        int m = int.Parse(Console.ReadLine()); //ввод количества столбцов матрицы
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

        int count = 0; //переменная для хранения количества одинаковых элементов матрицы
        Console.WriteLine("Одинаковые элементы матрицы на четных строках:");

        for (int i = 0; i < n; i += 2)
        { //перебираются элементы матрицы на чётных строках
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < m; k++)
                { //ищутся одинаковые элементы
                    if (matrix[i, j] == matrix[i, k] && j != k)
                    {
                        Console.WriteLine(matrix[i, j]); //если элементы одинаковы и находятся на чётной строке, то они выводятся на экран
                        count++; //увеличивается счётчик одинаковых элементов
                    }
                }
            }
        }

        Console.WriteLine("Количество одинаковых элементов матрицы: {0}", count); //вывод количества одинаковых элементов
    }
}