/*
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2
*/

// метод инициализации массива
// min - задает минимальное рандомное число
// max - задает максимальное рандомное число
// аргумент demension оставил, чтобы ограничить вывод чисел, для более легкой проверки
int[] InitArray(int demension, int min, int max)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(min, max);
    }

    return arr;

}

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод подсчета четных чисел в массиве
int CountNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

// проверяем работу написанных методов
int[] randomArr = InitArray(5, 100, 1000);
Console.Write("Массив случайных трехзначных чисел: ");
PrintArray(randomArr);
int countNumber = CountNumbers(randomArr);

if (countNumber != 0)
{
    Console.WriteLine($"Количество чётных чисел в массиве {countNumber}");
}
else
{
    Console.WriteLine($"В массиве нет чётных чисел!");
}