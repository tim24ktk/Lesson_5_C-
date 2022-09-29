/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
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

// метод подсчета суммы элементов, стоящих на нечётных позициях
int GetSumm(int[] arr)
{
    int summ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += arr[i];
        }
    }

    return summ;
}

// проверяем работу написанных методов
int[] randomArr = InitArray(5, 1, 10);
Console.Write("Одномерный массив, заполненный случайными числами: ");
PrintArray(randomArr);
int summ = GetSumm(randomArr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {summ}");