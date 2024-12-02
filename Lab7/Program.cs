using System.Linq;
//Exercise 1
int[] removeElement(int[] array, int item)
{
    return array.Where(x => x != item).ToArray();
}

int[] array = [1, 2, 3, 4, 5, 5, 6, 7];

int[] test1 = removeElement(array, 5);
Console.WriteLine("[{0}]", string.Join(", ", test1));//Outputs [1, 2, 3, 4, 6, 7]
int[] test2 = removeElement(array, 10);
Console.WriteLine("[{0}]", string.Join(", ", test2));//Removes nothing

//Exercise 2
int[] removeElementImproved(int[] array, params int[] items)
{
    return array.Where(item => !items.Contains(item)).ToArray();
}

int[] test3 = removeElementImproved(array, 5, 1, 6);
Console.WriteLine("[{0}]", string.Join(", ", test3));//Outputs [2, 3, 4, 7]
int[] test4 = removeElementImproved(array, 3, 4, 10);
Console.WriteLine("[{0}]", string.Join(", ", test4));//Outputs [1, 2, 5, 5, 6, 7]

//Exercise 3
int[] unique(int[] array)
{
    Array.Sort(array);
    List<int> unique = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1 || array[i] != array[i + 1])
        {
            unique.Add(array[i]);
        }
    }
    int[] result = unique.ToArray();
    return result;
}

int[] test5 = unique([2, 1, 1, 3, 2, 3]);
Console.WriteLine("[{0}]", string.Join(", ", test5));//Outputs [1, 2, 3]

//Exercise 4
int[] difference(int[] array1, int[] array2)
{
    return array1.Where(item => !array2.Contains(item)).ToArray();
}

int[] array1 = [7, -2, 10, 5, 0];
int[] array2 = [0, 10];
int[] test6 = difference(array1, array2);
Console.WriteLine("[{0}]", string.Join(", ", test6));//Outputs [7, -2, 5]
