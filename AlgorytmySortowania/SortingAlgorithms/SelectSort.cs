
namespace AlgorytmySortowania.SortingAlgorithms;

public sealed class SelectSort
{
    // CF wymaga private, z asp.net weim o tym
    private SelectSort()
    {
    }

    public static void Sort(List<int> list, out List<int> sortedList)
    {
        sortedList = new(list);
        for (int i = 0; i < sortedList.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < sortedList.Count; j++)
            {
                if (sortedList[j] < sortedList[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                (sortedList[i], sortedList[minIndex]) = (sortedList[minIndex], sortedList[i]);
            }
        }
    }
}
