private static List<int> CombineNum()
{
    List<int> list = new List<int>() { 1, 2, 3, 4 };
    List<int> numlist = new List<int>();
    foreach (int i in list)
    {
        List<int> list1 = new List<int>(list);
        list1.Remove(i);
        foreach (int j in list1)
        {
            List<int> list2 = new List<int>(list1);
            list2.Remove(j);
            foreach (int h in list2)
            {
                numlist.Add(i * 100 + j * 10 + h);
            }
        }
    }
    return numlist;
}

