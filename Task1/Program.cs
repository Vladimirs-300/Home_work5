// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "; ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    System.Console.WriteLine();
}

const int MIN_ELEMENTS = 100;
const int MAX_ELEMENTS = 999;

int length = Prompt("Введите длину массива -> ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);