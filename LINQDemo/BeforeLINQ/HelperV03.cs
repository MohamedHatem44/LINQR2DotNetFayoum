using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo.BeforeLINQ
{
    public static class HelperV03
    {
        /*------------------------------------------------------------------*/
        public static List<Employee> FilterEmployees(this List<Employee> employees,
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
