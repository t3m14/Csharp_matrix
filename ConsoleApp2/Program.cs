using System;

class Program
{
    static void Main()
    {
        try
        {
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
            Console.WriteLine("Введите матрицу:");

            // заполнение матрицы элементами
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int minValue = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < n; i++) // перебор всех строк
            {
                // перебор всех правых элементов
                if (matrix[i, minIndex] <= minValue)
                {
                    minValue = matrix[i, m - 1];
                    minIndex = i;
                    
                }
                
            }
                Console.WriteLine($"В столбце {m - 1} наименьший элемент: {minValue} находится в строке {minIndex + 1}");
        }
        catch (FormatException) // обработка ошибки - неверный формат ввода
        {
            Console.WriteLine("Неверный формат ввода. Попробуйте еще раз.");
        }
    }
}
