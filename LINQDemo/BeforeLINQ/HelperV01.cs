namespace LINQDemo.BeforeLINQ
{
    public class HelperV01
    {
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameStartWith(string value)
        {
            var employees = Repository.GetEmployees();
            var result = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.Name.ToLower().StartsWith(value.ToLower()))
                {
                    result.Add(employee);
                }
            }
            return result;
        }
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameEndWith(string value)
        {
            var employees = Repository.GetEmployees();
            var result = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.Name.ToLower().EndsWith(value.ToLower()))
                {
                    result.Add(employee);
                }
            }
            return result;
        }
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameContains(string value)
        {
            var employees = Repository.GetEmployees();
            var result = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.Name.ToLower().Contains(value.ToLower()))
                {
                    result.Add(employee);
                }
            }
            return result;
        }
        /*------------------------------------------------------------------*/
    }
}
