using System.Diagnostics.CodeAnalysis;

namespace LINQDemo
{
    public class EmpComp : IEqualityComparer<Employee>
    {
        /*------------------------------------------------------------------*/
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id;
        }
        /*------------------------------------------------------------------*/
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
        /*------------------------------------------------------------------*/
    }
}
