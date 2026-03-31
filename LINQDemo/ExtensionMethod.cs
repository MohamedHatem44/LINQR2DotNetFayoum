namespace LINQDemo
{
    public static class ExtensionMethod
    {
        /*------------------------------------------------------------------*/
        public static int GetWordsCount(this string str)
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
