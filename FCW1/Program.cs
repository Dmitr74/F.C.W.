// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Пример:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Критерий поиска, количество символов: ");
int value = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    string? str = Convert.ToString(Console.ReadLine());
    arr[i] = str!;
}
Console.WriteLine();
Console.Write($"Введённый массив: ");
PrintArray(arr);

string[] newArr = new string[size];
int count = 0;
for (int j = 0; j < size; j++)
{
    if (arr[j].Length <= value)
    {
        newArr[count] = arr[j];
        count++;
    }
}
Console.WriteLine();
Console.Write($"Результат поиска и сортировки в массиве: ");
PrintArray(newArr);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}
