{
    List<int> numbers = new List<int> { 2, 7, 4, 1, 8 };
    Console.WriteLine("Наибольшая сумма двух чисел в списке: " + FindLargestSum(numbers)[1] + " + " + FindLargestSum(numbers)[0] + " = " + FindLargestSum(numbers)[2]);
}

static int[] FindLargestSum(List<int> numbers)
{
    if (numbers.Count < 2)
    {
        throw new ArgumentException("Список должен содержать как минимум два элемента.");
    }

    numbers.Sort();
    int[] nums= { numbers[numbers.Count - 1], numbers[numbers.Count - 2], numbers[numbers.Count - 1] + numbers[numbers.Count - 2] };
    return nums;
}