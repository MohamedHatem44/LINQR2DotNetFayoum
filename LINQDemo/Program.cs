using LINQDemo.BeforeLINQ;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Collections
            //// Base for all Collections
            //// 1- IEnumerable
            //// 2- ICollection
            //List<int> ints1 = new List<int>() { 1, 2, 3, 4, 5 };
            //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>() { { 1, "One" }, { 2, "Two" }, { 3, "Three" } };

            //IEnumerable<int> ints2 = new List<int>() { 1, 2, 3, 4, 5 };
            ////IEnumerable<int> ints3 = new IEnumerable<int>() { 1, 2, 3, 4, 5 }; XXXX
            //// LINQ Return IEnumerable Base
            #endregion
            /*------------------------------------------------------------------*/
            #region Named Object
            //Student student = new Student
            //{
            //    Id = 1,
            //    Name = "John",
            //    Age = 20
            //};
            //// Named Object => Object with Reference Name
            //student.Name = "Updated";
            //Console.WriteLine(student); // Output: LINQDemo.Student
            //// override tostring()
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Object
            //// Anonymous Object => Object without Reference Name
            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = 1, Name = "John", Age = 20 },
            //    new Student { Id = 2, Name = "Jane", Age = 22 },
            //    new Student { Id = 3, Name = "Doe", Age = 21 }
            //};

            ////new Student() // Object on the fly
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Function
            //// Anonymous Function => Function without Reference Name
            //// (int x, int y) => x + y
            //Func<int, int, int> sum = (x, y) => x + y;

            //// Delegates
            //// Built-in Delegates 3
            //// 1- Predicate
            //// Return Type bool and take only 1 input param
            //Predicate<Student> predicate = s => s.Age > 20;

            //// 2- Action
            //// Return Type void and take 0 to 16 input param
            //Action action1 = () => Console.WriteLine("Hello World");
            //Action<int> action2 = (x) => Console.WriteLine(x);

            //// 3- Func
            //// Return Type Generic and take 0 to 16 input param
            //Func<int> func1 = () => 6;
            //Func<int, int, int> func2 = (x, y) => x + y;
            //Func<double, double, int> func3 = (x, y) => (int)(x + y);
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Type
            //Student student = new Student
            //{
            //    Id = 1,
            //    Name = "John",
            //    Age = 20
            //};

            //var s1 = new { SSN = 1, FullName = "Ali" };
            //Console.WriteLine(s1); // Output: { SSN = 1, FullName = Ali }
            //Console.WriteLine(s1.GetType());

            ////// ReadOnly
            ////s1.SSN = 6; // Error

            ////// var 
            ////// LINQ
            ////var x = 10;
            ////x = ""; // Error
            ////var z; // Error 
            #endregion
            /*------------------------------------------------------------------*/
            #region Before LINQ
            ////  Items / 2
            //List<int> ints4 = new List<int>() { 1, 2, 3, 4, 5 };
            //List<int> result1 = new List<int>();
            //foreach (int item in ints4)
            //{
            //    if (item % 2 == 0)
            //    {
            //        result1.Add(item / 2);
            //    }
            //}
            //var result2 = ints4.Where(); // LINQ
            #endregion
            /*------------------------------------------------------------------*/
            #region Extension Method
            //string str = "Hello World from ITI";
            //int count1 = Helper.GetWordsCount(str);
            //Console.WriteLine(count1);

            //int count2 = str.GetWordsCount(); // Extension Method
            //int count3 = ExtensionMethod.GetWordsCount(str); // Extension Method
            #endregion
            /*------------------------------------------------------------------*/
            #region Before LINQ
            //var emps = Repository.GetEmployees();

            //// V01
            //var q1 = HelperV01.GetEmployeesWithNameStartWith("MO");
            //var q2 = HelperV01.GetEmployeesWithNameEndWith("MO");
            //var q3 = HelperV01.GetEmployeesWithNameContains("MO");
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}

            //// V02
            //var q4 = HelperV02.FilterEmployees(emps, e => e.Name.ToLower().StartsWith("MO".ToLower()));

            //// V03
            //var q5 = HelperV03.FilterEmployees(emps, e => e.Age > 25);
            //var q6 = emps.FilterEmployees(e => e.Age > 25); // Extension Method
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ Definition
            // Features Added on Collections
            // 40 Additional Methods (Extention Methods) System.linq
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            // that provides a standardized way to query data from various data sources using
            // a common syntax within programming languages like C#"
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ
            // 1- Query Syntax => Like SQL Syntax [Limited 12/40 Method]
            // 2- Method Syntax [Fluent API] => Lambda Expression [All 40 Method]
            #endregion
            /*------------------------------------------------------------------*/
            #region Respository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();

            //Console.WriteLine("---------------------------------------------------");
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------------------");
            //foreach (var item in departments)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------------------");
            #endregion
            /*------------------------------------------------------------------*/
            #region Method Sytax [Fluent API] Function Chaining
            //// namespace System.Linq
            //// Enumerable => Static Class that contain all LINQ Methods as Extension Methods
            //var q7 = employees.Where(e => e.Age > 25);
            //var q8 = Enumerable.Where(employees, e => e.Age > 25); // Same as q7

            //var q9 = employees.Where(e => e.DeptId == 1);

            //var q10 = employees             // 10
            //    .Where(e => e.DeptId == 1)  // 3
            //    .Where(e => e.Age > 25);    // 2

            //var q11 = employees.Where(e => e.DeptId == 1 && e.Age > 25);

            //List<Employee> q12 = employees.Where(e => e.DeptId == 1 && e.Age > 25).ToList();

            //IEnumerable<Employee> q13 = employees.Where(e => e.DeptId == 1 && e.Age > 25);

            //var q14 = employees          // 10
            //    .Where(e => e.Age > 25)  // 7
            //    .OrderBy(e => e.DeptId); // 7

            //var q15 = employees
            //    .Where(e => e.Age > 25)
            //    .OrderBy(e => e.DeptId)
            //    .OrderBy(e => e.Name);

            //var q16 = employees
            //    .Where(e => e.Age > 25)
            //    .OrderBy(e => e.DeptId)
            //    .ThenBy(e => e.Name);

            //foreach (var item in q14)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Query Syntax
            //// Select * from Employees
            //// Select * from Employees where Age > 25
            //// Limited 12/40

            //// from - where - select
            //var q17 = from e in employees
            //          select e;

            //var q17_1 = q17.Where(e => e.Age > 25);

            //var q18 = from e in employees
            //          where e.Age > 25
            //          select e;

            //var q19 = from e in employees
            //          where e.Age > 25 && e.DeptId == 1
            //          select e;

            //var q20 = from e in employees
            //          where e.Age > 25 && e.DeptId == 1
            //          orderby e.Name descending
            //          select e;

            //Console.WriteLine(q20);
            //// System.Linq.Enumerable+OrderedIterator`2[LINQDemo.Employee,System.String]
            //foreach (var item in q17)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Single Element => Return one Element Only
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault
            // Find => EF

            #region First and FirstOrDefault
            //Employee q21_1 = employees.First();
            //var q21 = employees.First();
            //var q22 = employees.First(e=>e.DeptId == 1);
            //var q23 = employees.First(e=>e.Id == 1000);

            //// First
            //// 1- Return First Element Only
            //// 2- If No ELement => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If More than One Element => Return First Element Only

            //var q24 = employees.FirstOrDefault();
            //var q25 = employees.FirstOrDefault(e => e.DeptId == 1);
            //var q26 = employees.FirstOrDefault(e => e.Id == 1000);
            //if (q26 is null)
            //{
            //    Console.WriteLine("No Element Found");
            //}
            //else
            //{
            //    Console.WriteLine(q26);
            //}

            //// FirstOrDefault
            //// 1- Return First Element Only
            //// 2- If No ELement => Return null and no Exception
            //// 3- If Found => Return Element
            //// 4- If More than One Element => Return First Element Only
            #endregion

            #region Last and LastOrDefault
            //var q27 = employees.Last();
            //var q28 = employees.Last(e => e.DeptId == 1);
            //var q29 = employees.Last(e => e.Id == 1000);

            //// Last
            //// 1- Return Last Element Only
            //// 2- If No ELement => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If More than One Element => Return Last Element Only

            //var q30 = employees.LastOrDefault();
            //var q31 = employees.LastOrDefault(e => e.DeptId == 1);
            //var q32 = employees.LastOrDefault(e => e.Id == 1000);

            //// LastOrDefault
            //// 1- Return Last Element Only
            //// 2- If No ELement => Return null and no Exception
            //// 3- If Found => Return Element
            //// 4- If More than One Element => Return Last Element Only
            //Console.WriteLine(q32);
            #endregion

            #region Single and SingleOrDefault
            //// Single => Return Single Element Only
            //var q33 = employees.Single(e=>e.Id == 1);
            //var q34 = employees.Single(e => e.DeptId == 1111);
            //var q35 = employees.Single(e => e.DeptId == 1);

            //// Single
            //// 1- Return Single Element Only
            //// 2- If No ELement => Throw Exception => Sequence contains no matching element
            //// 3- If Found one => Return Element
            //// 4- If More than One Element => Sequence contains more than one matching element

            //var q36 = employees.SingleOrDefault(e=>e.Id == 1);
            //var q37 = employees.SingleOrDefault(e => e.DeptId == 1111);
            //var q38 = employees.SingleOrDefault(e => e.DeptId == 1);

            //// SingleOrDefault
            //// 1- Return Single Element Only
            //// 2- If No ELement => Return null and no Exception
            //// 3- If Found one => Return Element
            //// 4- If More than One Element => Sequence contains more than one matching element
            //Console.WriteLine(q37);
            #endregion

            #region ElementAt and ElementAtOrDefault
            //// ElementAt => Return Element at specific Index
            //var q39 = employees.ElementAt(1);
            //var q40 = employees.ElementAt(100);
            //Console.WriteLine(q39);

            //// ElementAt
            //// 1- Return Element at specific Index
            //// 2- If Index Out of Range => Throw Exception => Index was out of range
            //// 3- If Index In Range => Return Element

            //var q41 = employees.ElementAtOrDefault(1);
            //var q42 = employees.ElementAtOrDefault(100);
            //Console.WriteLine(q42);

            //// ElementAtOrDefault
            //// 1- Return Element at specific Index 
            //// 2- If Index Out of Range => Return null and no Exception
            //// 3- If Index In Range => Return Element
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
            #region List of Int
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            //var q = ints.Where(i => i > 1).ToList();
            //ints.Add(6);
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
