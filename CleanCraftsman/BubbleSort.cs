namespace CleanCraftsman
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> list)
        {
            if(list.Count > 1)
            {
                for (int limit = list.Count - 1; limit > 0; limit--)
                {
                    for (int firstIndex = 0; firstIndex < limit; firstIndex++)
                    {
                        var secondIndex = firstIndex + 1;

                        if (list[firstIndex] > list[secondIndex])
                        {
                            int first = list[firstIndex];
                            int second = list[secondIndex];

                            list[firstIndex] = second;
                            list[secondIndex] = first;
                        }
                    }
                }
            }

            return list;
        }
    }
}