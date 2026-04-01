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
            #region Deffered Execution vs Immediate Execution
            //// All LINQ Methods are Deffered Execution Except Methods that return Single Object
            //// or Collection(ToList, ToArray, Count, etc.)

            //// Deffered Execution
            //// 1 - Query is not executed until you iterate over the collection
            //// 2 - If the source collection changes, the query will reflect those changes
            //// 3 - Example: Where, Select, etc.

            //// Immediate Execution
            //// 1 - Query is executed immediately and the result is stored
            //// 2 - If the source collection changes, the query will not reflect those changes
            //// 3 - Example: ToList, ToArray, Count, Single Object, etc.

            //var q43 = employees.Where(e => e.DeptId == 1);
            //var emp1 = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 15000,
            //    DeptId = 1
            //};
            //employees.Add(emp1);

            //foreach (var item in q43) // Execute Query Here
            //{
            //    Console.WriteLine(item);
            //}

            //var q44 = employees.Where(e => e.DeptId == 1).ToList(); // Execute Query Here
            //var emp2 = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 15000,
            //    DeptId = 1
            //};
            //employees.Add(emp2);

            //foreach (var item in q44)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Select Top
            //// Take
            //// TakeLast
            //// TakeWhile
            //// Skip
            //// SkipLast
            //// SkipWhile

            //var q45 = employees.Take(2);
            //var q46 = employees.Take(1000);

            //var q47 = employees.TakeLast(2);
            //var q48 = employees.TakeLast(20);

            //var q49 = employees.Skip(2);
            //var q50 = employees.Skip(2).Skip(2);

            //var q51 = employees.Skip(2).Take(2);
            //var q52 = employees.SkipLast(3);

            //// TakeWhile
            //// TakeWhile takes elements from the sequence
            //// as long as a specified condition is true.
            //// Once the condition becomes false,
            //// it stops taking elements, even if there are more elements
            //// in the sequence that would satisfy the condition.
            //var q53 = employees.TakeWhile(e => e.DeptId == 1);
            //var q54 = employees.TakeWhile(e => e.DeptId == 2);

            //// SkipWhile skips elements from the sequence
            //// as long as a specified condition is true.
            //// Once the condition becomes false,
            //// it stops skipping elements and includes the rest of the sequence,
            //// even if there are more elements in the sequence that would satisfy the condition.
            //var q55 = employees.SkipWhile(e => e.DeptId == 1);
            //var q56 = employees.SkipWhile(e => e.DeptId == 2);

            //// Take With Range
            //var q57 = employees.Take(2..5);

            //Range range = new Range(2, 6);
            //var q58 = employees.Take(range);

            //foreach (var item in q58)
            //{
            //    Console.WriteLine(item);
            //}

            //// Page Number 1
            //// Page Size 5
            //// var q = employees.Skip((pageNumber - 1) * 5).Take(pageSize);
            #endregion
            /*------------------------------------------------------------------*/
            #region All, Any
            //List<int> ints1 = new List<int>() { 1, 2, 3, 4, 5 };
            //var q59 = ints1.Any(i => i % 2 == 0);
            //var q60 = ints1.All(i => i % 2 == 0);

            //Console.WriteLine(q59);
            //Console.WriteLine(q60);
            #endregion
            /*------------------------------------------------------------------*/
            #region Distinct
            //List<int> ints2 = new List<int>() { 1, 1, 2, 1, 2, 3, 3, 4, 5 };
            //var q61 = ints2.Distinct();

            //foreach (var item in q61)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Distinct and DistinctBy Employee
            //List<Employee> emps = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1 },
            //    new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2 },
            //    new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3 },
            //    new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4 },
            //    new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DeptId = 1 },
            //    new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2 },
            //    new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3 },
            //    new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4 },
            //    new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //};

            //var q62 = emps.Distinct(); // XXXXX

            //var q63 = emps.Distinct(new EmpComp());

            //var q64 = emps.DistinctBy(e => e.Id);

            //foreach (var item in q64)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Projection => Select Col
            //var q65 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => e.Name);

            //var q66 = from e in employees
            //          where e.DeptId == 1
            //          select e.Name;

            ////var q67 = from e in employees
            ////          where e.DeptId == 1
            ////          select e.Name && e.Age; // XXXX Not Allowed


            //var q68 = employees
            //       .Where(e => e.DeptId == 1)
            //       .Select(e => new Employee { Name = e.Name, Age = e.Age });

            //var q69 = employees
            //        .Where(e => e.DeptId == 1)
            //        .Select(e => new { Name = e.Name, Age = e.Age });

            //var q70 = employees
            //        .Where(e => e.DeptId == 1)
            //        .Select(e => new { FullName = e.Name, EmpAge = e.Age });

            //var q71 = employees
            //        .Where(e => e.DeptId == 1)
            //        .OrderBy(e => e.Name)
            //        .Select(e => new { FullName = e.Name, EmpAge = e.Age })
            //        .OrderBy(e => e.EmpAge);

            //foreach (var item in q71)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Query Suntax]
            //// Select All Employees with their Department Name

            //var q72 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { EmployeeId = e.Id, EmployeeName = e.Name, DepartmentName = d.DeptName };

            //var q73 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { Employee = e, DepartmentName = d.DeptName };

            //foreach (var item in q73)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Method Syntax]
            //// public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
            //// (this IEnumerable<TOuter> outer,
            //// IEnumerable<TInner> inner, Func<TOuter,
            //// TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector,
            //// Func<TOuter, TInner, TResult> resultSelector) =>
            //// Join(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer: null);

            //var q74 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { Employee = e, Department = d.DeptName });

            //var q75 = departments.Join(
            //    employees,
            //    d => d.DeptId,
            //    e => e.DeptId,
            //    (d, e) => new { Employee = e, Department = d.DeptName });

            //foreach (var item in q74)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Min, Max, Count, Avg, Sum
            //var q76 = employees.Min(e => e.Salary);
            //var q77 = employees.Max(e => e.Salary);
            //var q78 = employees.Count(e => e.Salary > 5000);
            //var q79 = employees.Average(e => e.Salary); 
            //var q80 = employees.Sum(e => e.Salary);

            //Console.WriteLine(q76);
            //Console.WriteLine(q77);
            //Console.WriteLine(q78);
            //Console.WriteLine(q79);
            //Console.WriteLine(q80);

            //var q81 = employees.Where(e => e.Salary > employees.Average(e => e.Salary));
            //var q82 = employees.Where(e => e.Salary > q79);
            #endregion
            /*------------------------------------------------------------------*/
            #region OfType
            //List<User> users = new List<User>
            //{
            //    new Male { Id = 1, Name = "Ahmed" },
            //    new Male { Id = 2, Name = "Mohamed" },
            //    new Female { Id = 3, Name = "Sara" },
            //    new Female { Id = 4, Name = "Mai" },
            //};

            //var q83 = users.OfType<Male>();
            //var q84 = users.OfType<Female>();

            //foreach (var item in q84)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Concat, Union, Expect, Intersect
            //List<int> ints3 = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> ints4 = new List<int>() { 9, 10, 11, 12 };

            //var q85 = ints3.Concat(ints4);
            //var q86 = ints3.Union(ints4);
            //var q87 = ints3.Except(ints4);
            //var q88 = ints3.Intersect(ints4);

            ////var q89 = employees1.IntersectBy(employees2, e => e.Id);

            //foreach (var item in q88)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Zip Operator
            //List<int> nums = new List<int>() { 1, 2, 3 };
            //List<string> names = new List<string>() { "One", "Two", "Three" };

            //var q90 = nums.Zip(names);
            //var q91 = nums.Zip(names, (num,name)=> new { Number = num, Name = name });

            //foreach (var item in q91)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region IndexedSelect and IndexedWhere
            //var q92 = employees.Select((e, i) => new { Employee = e, Index = i });
            //foreach (var item in q92)
            //{
            //    Console.WriteLine(item);
            //}

            //var q93 = employees.Where((emp, i) => emp.DeptId == 1 && i < 5);
            //foreach (var item in q93)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Insert, Update, Delete
            //// Insert
            //var emp3 = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 15000,
            //    DeptId = 1
            //};
            //employees.Add(emp3);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            //// Update
            //// 1- Catch To Update
            //var empToUpdate = employees.FirstOrDefault(e => e.Id == 1);

            //if (empToUpdate == null)
            //{
            //    Console.WriteLine("Employee not found");
            //}
            //else
            //{
            //    // 2- Update Properties
            //    empToUpdate.Name = "Updated Name";
            //    empToUpdate.Salary = 20000;
            //}
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            //// Delete
            //// 1- Catch To Delete
            //var empToDelete = employees.FirstOrDefault(e => e.Id == 1);

            //if (empToDelete == null)
            //{
            //    Console.WriteLine("Employee not found");
            //}
            //else
            //{
            //    // 2- Delete
            //    employees.Remove(empToDelete);
            //}
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region GroupBy
            //var q94 = employees.GroupBy(e => e.DeptId);
            ////foreach (var item in q94)
            ////{
            ////    Console.WriteLine(item); // System.Linq.Grouping`2[System.Int32,LINQDemo.Employee]
            ////}

            //var q95 = from e in employees
            //          group e by e.DeptId;

            //var q96 = from e in employees
            //          group e by e.DeptId into g
            //          select g;

            //var q97 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { Employee = e, Department = d.DeptName })
            //    .GroupBy(g => g.Department);

            //var q98 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          group e by d.DeptName;

            //foreach (var item in q98)
            //{
            //    Console.WriteLine("Department: " + item.Key);
            //    foreach (var employee in item)
            //    {
            //        Console.WriteLine(employee);
            //    }
            //}

            ////// [{1, Emp1}, {1, Emp2}, {1, Emp3}, {2, Emp4}, {2, Emp5}]
            ////// [g1 = {Key = 1, List<Emp1, Emp2, Emp3>}, g2 = {Key = 2, List<Emp1, Emp2, Emp3>}]
            ////// group = {Key = 1, List<Emp1, Emp2, Emp3>}
            ////// g.key = 1
            ////// g = Collection<Emp1, Emp2, Emp3>
            #endregion
            /*------------------------------------------------------------------*/
            #region GroupBy and Aggregation
            //// Select Total Salary, Min Salary, Max Salary, Avg Salary for each Department and select Department Name
            //var q99 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { Employee = e, Department = d.DeptName })
            //    .GroupBy(g => g.Department);

            ////var q = employees.Select(e=>)
            ////// IEnu<h>
            ////// h => Employee
            ////// h => IGrouping<int ,emp>
            ////// item => Group

            //var q99_ = q99.Select(g => new
            //{
            //    Department = g.Key,
            //    TotalSalary = g.Sum(e => e.Employee.Salary),
            //    MinSalary = g.Min(e => e.Employee.Salary),
            //    MaxSalary = g.Max(e => e.Employee.Salary),
            //    AvgSalary = g.Average(e => e.Employee.Salary),
            //});

            //var q100 = from e in employees
            //           join d in departments
            //           on e.DeptId equals d.DeptId
            //           group e by d.DeptName into g
            //           select new
            //           {
            //               Department = g.Key,
            //               TotalSalary = g.Sum(e => e.Salary),
            //               MinSalary = g.Min(e => e.Salary),
            //               MaxSalary = g.Max(e => e.Salary),
            //               AvgSalary = g.Average(e => e.Salary),
            //           };

            //foreach (var item in q100)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Mix Query
            //var q101 = (from e in employees
            //            where e.DeptId == 2
            //            select e).FirstOrDefault();
            //Console.WriteLine(q101);
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
