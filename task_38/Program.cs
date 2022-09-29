/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76
*/

// метод инициализации массива
// min - задает минимальное рандомное число
// max - задает максимальное рандомное число
// аргумент demension оставил, чтобы ограничить вывод чисел, для более легкой проверки

double[] InitArray(int demension, double minNumber, double maxNumber)
{
    double[] arr = new double[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (maxNumber - minNumber) + minNumber, 3);
    }

    return arr;
}

//метод, который печатает массив на консоль
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, который получает минимальное и максимальное значение элемента массива
//первый возвращаемый элемент - минимальный
//второй возвращаемый элемент - максимальный
(double, double) GetNums(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
            maxNumber = array[i];
        else if (minNumber > array[i])
            minNumber = array[i];
    }

    return (maxNumber, minNumber);

}

// проверяем работу написанных методов
double[] randomArr = InitArray(5, 1, 10);
Console.Write("Одномерный массив, заполненный случайными вещественными числами: ");
PrintArray(randomArr);
(double maxNumber, double minNumber) = GetNums(randomArr);
double result = Math.Round(maxNumber - minNumber, 3);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {result}");
