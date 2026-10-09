namespace AlgorytmySortowania.SortingAlgorithms;

public sealed class BubbleSort
{
    // CF wymaga private, z asp.net weim o tym
    private BubbleSort()
    {
    }

    public static void Sort(List<int> list, out List<int> sortedList)
    {
        sortedList = new(list);
        for (int i = 0; i < sortedList.Count - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < sortedList.Count - i - 1; j++)
            {
                if (sortedList[j] > sortedList[j + 1])
                {
                    (sortedList[j], sortedList[j + 1]) = (sortedList[j + 1], sortedList[j]);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }
}
