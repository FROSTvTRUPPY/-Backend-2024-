Console.Write("Введите целые числа через пробел:");

string input = Console.ReadLine(); // Чтение ввода пользователя и разделение его на числа
string[] numbersStr = input.Split(' ');
int[] numbers = new int[numbersStr.Length];


for (int i = 0; i < numbersStr.Length; i++)
{
    numbers[i] = int.Parse(numbersStr[i]); // Преобразование строковых значений в целые числа
}

SortArray(numbers);

Console.Write("\nОтсортированный массив:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.Write("\nВведите искомое число:");

string input2 = Console.ReadLine(); // Чтение ввода пользователя и разделение его на числа
int target;
target = int.Parse(input2); // Преобразование строковых значений в целые числа
Console.WriteLine("Индекс элемента " + target + " в списке: [" + BinarySearch(numbers, target) + "]");

static void SortArray(int[] arr)
{
    Array.Sort(arr);
}

static int BinarySearch(int[] numbers, int target)
{
    int left = 0;
    int right = numbers.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (numbers[mid] == target)
        {
            return mid;
        }
        else if (numbers[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1; // Элемент не найден
}