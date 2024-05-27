int[] A = { 2, 4, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
int[] B = { 2, 1, 4, 3, 6, 9 };

Console.Write("    Изначальный массив A: ");
foreach (int num in A)
{
    Console.Write(num + " ");
}

Console.Write("\n                массив B: ");
foreach (int num in B)
{
    Console.Write(num + " ");
}

SortArrayByOrder(A, B);

Console.Write("\nОтсортированный массив A: ");
foreach (int num in A)
{
    Console.Write(num + " ");
}

static void SortArrayByOrder(int[] A, int[] B)
{
    Dictionary<int, int> indexMap = new Dictionary<int, int>();

    for (int i = 0; i < B.Length; i++)// Создаем карту индексов элементов из B в A
    {
        indexMap[B[i]] = i;
    }

    Array.Sort(A, (x, y) =>
    {
        if (indexMap.ContainsKey(x) && indexMap.ContainsKey(y))
        {
            return indexMap[x].CompareTo(indexMap[y]);// Если оба элемента присутствуют в B, сравниваем их порядок в B
        }
        else if (indexMap.ContainsKey(x))
        {
            return -1;// Если только x присутствует в B, то он должен быть раньше
        }
        else if (indexMap.ContainsKey(y))
        {
            return 1;// Если только y присутствует в B, то y должен быть раньше
        }
        else
        {
            return y.CompareTo(x);// Если ни x, ни y не присутствуют в B, сортируем их по убыванию
        }
    });
}