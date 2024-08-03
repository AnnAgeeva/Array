Console.WriteLine("Сложение матриц");
Console.WriteLine();
Console.WriteLine("Введите количество строк матрицы");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int j = int.Parse(Console.ReadLine());
Console.WriteLine();

Random r = new Random();

int[,] a = new int[i, j];
int[,] b = new int[i, j];
for (i = 0; i < a.GetLength(0); i++)
{

    for (j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = r.Next(10);
        Console.Write($"{a[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (i = 0; i < b.GetLength(0); i++)
{
    for (j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = r.Next(10);
        Console.Write($"{b[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Сумма матриц");
int[,] c = new int[i, j];
for (i = 0; i < c.GetLength(0); i++)
{
    for (j = 0; j < c.GetLength(1); j++)
    {
        c[i, j] = a[i, j] + b[i, j];
        Console.Write($"{c[i, j]}  ");
    }
    Console.WriteLine();
}
