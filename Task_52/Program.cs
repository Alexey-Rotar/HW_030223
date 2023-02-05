// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Генерация случайного 2D-массива размерностью [2...10] и диапазоном значений [0...10]
int[,] CreatingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[rnd.Next(2, 11), rnd.Next(2, 11)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 11);
    }
    return array;
}

// Вывод массива
void OutputingArray(float[] array)
{
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write(array[i].ToString("#.0") + "; ");
        else
            Console.Write(array[i].ToString("#.0") + ".");
            Console.WriteLine("");
}

// Вывод 2D-массива
void OutputingArray2D(int[,] array)
{
    Console.WriteLine("Сформированный массив:");
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

// Получение массива средних значений по столбцам
float[] GgettingColumnsAverageValues(int[,] array)
{
    float[] resultArray = new float[array.GetLength(1)];
    for (int i=0; i<array.GetLength(1); i++)
    {
        for (int j=0; j<array.GetLength(0); j++)
            resultArray[i]+=array[j, i];
        resultArray[i]/=array.GetLength(0);
    } 
    return resultArray;   
}


int [,] array2D = CreatingArray2D();
OutputingArray2D(array2D);

Console.WriteLine("Средние значения по столбцам:");
OutputingArray(GgettingColumnsAverageValues(array2D));