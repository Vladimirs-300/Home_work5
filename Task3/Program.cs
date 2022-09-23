// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = new Random().Next(1, 11);

System.Console.WriteLine($"Количетсов элементов массива: {size} \t");

double[] FillSourcearray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
    double difference = array.Max() - array.Min();
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillSourcearray(size));
System.Console.WriteLine();