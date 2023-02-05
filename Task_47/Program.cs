// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Создание 2D-массива с указанными размерностью и диапазоном случайных значений (float)
float[,] CreatingArray2D(uint lines, uint columns, int minValue, int maxValue)
{
    float[,] array = new float[lines, columns];
    Random rnd = new Random();
    for (int i=0; i<lines; i++)
    {
        for (int j=0; j<columns; j++)
        array[i, j] = rnd.Next(minValue, maxValue) + (float)(rnd.Next(0, 10))/10;
    }
    return array;
}

// Вывод 2D-массива
void OutputingArray2D(float[,] array)
{
    Console.WriteLine("Сформированный массив:");
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("0.0") + "\t");
        Console.WriteLine();
    }
}

// Интерфейс
Console.WriteLine("Введите количество строк 2D-массива:");
uint lines;
while (!uint.TryParse(Console.ReadLine(), out lines) || lines<2)
{
    Console.WriteLine("Некорректное значение!");            
}

Console.WriteLine("Введите количество столбцов 2D-массива:");
uint columns;
while (!uint.TryParse(Console.ReadLine(), out columns) || columns<2)
{
    Console.WriteLine("Некорректное значение!");            
}

Console.WriteLine("Введите минимальное значение элемента массива:");  
int minValue;
while (!int.TryParse(Console.ReadLine(), out minValue))
{
    Console.WriteLine("Некорректное значение!");            
}  

Console.WriteLine("Введите максимальное значение элемента массива:");
int maxValue;
while (!int.TryParse(Console.ReadLine(), out maxValue) || maxValue<minValue)
{
    Console.WriteLine("Некорректное значение!");            
}



OutputingArray2D(CreatingArray2D(lines, columns, minValue, maxValue));