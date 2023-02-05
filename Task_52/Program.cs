// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
// Генерация случайного 2D-массива размерностью [2...10] и диапазоном значений [0...9]
int[,] GeneratingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[rnd.Next(2, 11), rnd.Next(2, 11)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
    }
    return array;
}
*/

// Заполнение массива указанной размерности
int[,] CreatingArray2D(uint lines, uint columns)
{
    Console.WriteLine("Вводите построчно значения 2D-массива через пробел:");
    string input;
    string[] numberStrings;
    int[,] array=new int[lines, columns];

    for (int i=0; i<lines; i++)
    {
        input=Console.ReadLine()!;
        numberStrings=input.Split(" ");
        for (int j=0; j<columns; j++)
            array[i, j]=int.Parse(numberStrings[j]); 
    }  
    return array;
}

// Вывод массива
void OutputingArray(float[] array)
{
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write(array[i].ToString("0.0") + ";\t");
        else
            Console.Write(array[i].ToString("0.0") + ".");
            Console.WriteLine("");
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

// Получение массива средних значений по столбцам
float[] GettingColumnsAverageValues(int[,] array)
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


int [,] array2D = CreatingArray2D(lines, columns);
OutputingArray2D(array2D);

Console.WriteLine("Средние значения по столбцам:");
OutputingArray(GettingColumnsAverageValues(array2D));