
Console.WriteLine("Введите целые числа через пробел:");

string input = Console.ReadLine(); // Чтение ввода пользователя и разделение его на числа
string[] numbersStr = input.Split(' ');
int[] numbers = new int[numbersStr.Length];


for (int i = 0; i < numbersStr.Length; i++)
{
    numbers[i] = int.Parse(numbersStr[i]); // Преобразование строковых значений в целые числа
}

SortArray(numbers);

Console.WriteLine("Отсортированный массив:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

static void SortArray(int[] arr)
{
    Array.Sort(arr);
}
