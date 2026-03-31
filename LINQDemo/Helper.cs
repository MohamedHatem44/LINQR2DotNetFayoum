namespace LINQDemo
{
    public static class Helper
    {
        /*------------------------------------------------------------------*/
        public static int GetWordsCount(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int count = str.Split(' ').Length;
                return count;
            }
            return 0;
        }
        /*------------------------------------------------------------------*/
    }
}
