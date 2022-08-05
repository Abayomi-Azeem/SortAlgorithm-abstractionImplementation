namespace Assignment2
{
    internal class sorter
    {
        public int[] InsertIntoListAscending(int[] list, int valueToInsert)
        {
            int insertLocation =list.Length ;
            if (list.Length == 0)
            {
                
                int[] sortedList = { valueToInsert };
                return sortedList;
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > valueToInsert)
                {
                    insertLocation = i;
                    break;
                }
            }
           
            int[] newSortedList = new int[list.Length + 1];
            bool injected = false;
            for (int i = 0; i < (list.Length + 1); i++)
            {
                if (i == insertLocation)
                {
                    newSortedList[insertLocation] = valueToInsert;
                    injected = true;
                }
                else
                {
                    if (injected)
                    {
                        newSortedList[i] = list[i - 1];
                    }
                    else
                    { newSortedList[i] = list[i]; }
                }

            }
             return newSortedList;
        }

        public int[] InsertIntoListDescending(int[] list, int valueToInsert)
        {
            int insertLocation = list.Length;
            if (list.Length == 0)
            {
                int[] sortedList = { valueToInsert };
                return sortedList;
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] < valueToInsert)
                {
                    insertLocation = i;
                    break;
                }
            }
            int[] newSortedList = new int[list.Length + 1];
            bool injected = false;
            for (int i = 0; i < (list.Length + 1); i++)
            {
                if (i == insertLocation)
                {
                    newSortedList[insertLocation] = valueToInsert;
                    injected = true;
                }
                else
                {
                    if (injected)
                    {
                        newSortedList[i] = list[i - 1];
                    }
                    else
                    { newSortedList[i] = list[i]; }
                }
            }
            return newSortedList;
        }
        static void Main(string[] args)
        {
            int[] unsortedList = { 7,4,10,9,6,11,3,1,5,2,8};
            int[] sortedListAsc = { };
            int[] sortedListDesc = { };
            var insertList = new sorter();
            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedListAsc = insertList.InsertIntoListAscending(sortedListAsc, unsortedList[i]);
                sortedListDesc = insertList.InsertIntoListDescending(sortedListDesc, unsortedList[i]);
            }
            Array.ForEach(sortedListAsc, Console.WriteLine);
            Console.WriteLine("\n\n");
            Array.ForEach(sortedListDesc, Console.WriteLine);
            

            
        }
    }
}