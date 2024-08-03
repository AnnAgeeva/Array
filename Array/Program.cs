
Console.WriteLine("Случайная матрица");
Console.WriteLine();
Console.WriteLine("Введите количество строк матрицы");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int j = int.Parse(Console.ReadLine());
Random r = new Random();

int[,] matrix = new int[i, j];
int sum = 0;
for (i = 0; i < matrix.GetLength(0); i++)
{

    for (j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = r.Next(10);
        Console.Write($"{matrix[i, j]}  ");
        sum = sum + matrix[i, j];
    }
    Console.WriteLine();

}
Console.WriteLine("Сумма элементов матрицы = " + sum);
Console.ReadKey();
