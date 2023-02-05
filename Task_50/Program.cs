// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Генерация 2D-массива со случайными размерностью [2...10] и диапазоном значений [0...100]
int[,] GeneratingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[rnd.Next(2, 11), rnd.Next(2, 11)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        array[i, j] = rnd.Next(0, 101);
    }
    return array;
}

// Вывод 2D-массива
void OutputingArray2D(int[,] array)
{
    Console.WriteLine("Сформированный массив:");
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

// Проверка наличия элемента и вывод
void CheckingElementArray2D(uint line, uint column, int[,] array)
{
    if (line>array.GetLength(0)-1 || column>array.GetLength(1)-1)
        Console.WriteLine("Такого элемента нет!");
    else
        Console.WriteLine("Значение элемента: " + array[line, column]);        
}


int [,] generatedArray2D = GeneratingArray2D();
OutputingArray2D(generatedArray2D);


// Интерфейс
Console.WriteLine("Введите позицию элемента.");
Console.WriteLine("Введите номер строки [0..." + (generatedArray2D.GetLength(0)-1) + "]:");
uint line;
while (!uint.TryParse(Console.ReadLine(), out line))
{
    Console.WriteLine("Некорректное значение!");            
}

Console.WriteLine("Введите номер столбца [0..." + (generatedArray2D.GetLength(1)-1) + "]:");
uint column;
while (!uint.TryParse(Console.ReadLine(), out column))
{
    Console.WriteLine("Некорректное значение!");            
}


CheckingElementArray2D(line, column, generatedArray2D);