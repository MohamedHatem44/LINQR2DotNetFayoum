namespace LINQDemo.BeforeLINQ
{
    public class HelperV02
    {
        /*------------------------------------------------------------------*/
        public static List<Employee> FilterEmployees(List<Employee> employees,
            Predicate<Employee> predicate)
        {
            //// External
            //var employees = Repository.GetEmployees();
            var result = new List<Employee>();

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
