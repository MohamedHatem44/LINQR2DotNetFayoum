namespace LINQDemo.BeforeLINQ
{
    internal static class HelperV04
    {
        /*------------------------------------------------------------------*/
        public static IEnumerable<T> FilterEmployees<T>(this IEnumerable<T> employees,
            Predicate<T> predicate)
        {
            var result = new List<T>();

            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    result.Add(employee);
                }
            }
            return result;
        }
        /*------------------------------------------------------------------*/
    }
}
