using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectDemo
{
    internal class LinqDemo
    {
        private IList<Employee> InitializeEmployee()
        {
            Employee emp1 = new Employee()
            {
                EmpID= 1,
                EmpName = "Lavanya",
                Salary = 12000,
                Department="Purchase"
            };
            Employee emp2 = new Employee()
            {
                EmpID = 2,
                EmpName = "Priya",
                Salary = 22000,
                Department= "Accounts"
            };
            Employee emp3 = new Employee()
            {
                EmpID = 3,
                EmpName = "Divya",
                Salary = 30000,
                Department="Purchase"
            };
            Employee emp4 = new Employee()
            {
                EmpID = 4,
                EmpName = "Praveen",
                Salary = 8000,
                Department="Accounts"
            };
            Employee emp5 = new Employee()
            {
                EmpID = 5,
                EmpName = "Ranjith",
                Salary = 25000,
                Department = "Accounts"
            };
            IList<Employee> empList=new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            return empList;
        }
        public void WhereClauseQueryDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IEnumerable<string> filteredEmp = from Employee in empList
                                           where Employee.Salary > 20000
                                            select Employee.EmpName;
            foreach (string s in filteredEmp)
                Console.WriteLine(s);
        }
        public void WhereClauseMethodDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IEnumerable<string> filtered = empList
                .Where(e => e.Salary > 20000)
                .Select(em =>em.EmpName);
            foreach (string emp in filtered)
                Console.WriteLine(emp);
        }
        public void WhereClauseMixedDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            var averageSalary=(from emp in empList
                              where emp.Salary>20000
                              select emp.Salary).Average();
            Console.WriteLine(averageSalary);
        }
        public void OrderByDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IEnumerable<Employee> eOrder = from e in empList
                                           where e.Salary > 20000
                                           orderby e.Salary descending
                                           select e;
            IEnumerable<Employee> eMethod=empList
                                    .OrderByDescending(e => e.Salary);
            //orderby
            foreach (Employee em in eMethod)
                Console.WriteLine(em);
        }
        public void GroupByDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            var eGroup = from e in empList
                         where e.Salary > 20000
                         group e by e.Department
                        ;
                //.groupby for method syntax
            foreach (var em in eGroup)
            {
                Console.WriteLine(em.Key);
                foreach (var e in em)
                    Console.WriteLine(e.Salary + " " + e.EmpName);
            }

        }
        public void ThenClauseDemo()
        {
            IList<Employee> empList = InitializeEmployee();
       var eThen=from e in empList
                 orderby e.Department ,e.EmpName
                 select e;
            var eThenMethod=empList.OrderBy(o=>o.Department)
                .ThenByDescending(o => o.EmpName);  //ThenBy
            foreach (var emp in eThenMethod)
                Console.WriteLine(emp);
        }
        public void FirstDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            var eFirst = (from e in empList
                          where e.Salary > 20000
                          orderby e.Salary descending
                          select e).First();
            var em = empList.First(n => n.Salary > 20000);
            //last
            
                Console.WriteLine(em);
        }

        
        public void TakeDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            var eTake = (from e in empList
                         select e).Take(3).ToList();  //TakeLast
            foreach (var e in eTake)
                Console.WriteLine(e);

        }
        public void SkipDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            var eSkip = (from e in empList
                         select e).Skip(3);
//Skip the First three Elements and Return Remaining Elements from the Data Source

            foreach(var e in eSkip)
            {
                Console.WriteLine(e);
            }
        }
        public void AggregateDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            int countEmp = (from e in empList
                            select e).Count();
           // int countMethod = empList.Count();
            Console.WriteLine("Count of records " + countEmp);
            var avg = (from e in empList
                       select e.Salary).Average();
            Console.WriteLine(avg);
        }
        public void DistintDemo()
        {
            IList<Employee> empList = InitializeEmployee();
        var dis=(from e in empList
                select e.Department).Distinct();
            //without distinct it will print with repetition
            foreach (var v in dis)
                Console.WriteLine(v);
        }
        public void takeWhileDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            //loop till condition is true,if condition is false,exits
            //if first value itself false nothing will be displayed
            var e = empList.TakeWhile(n => n.Salary < 30000);
            foreach (var t in e)
                Console.WriteLine(t);
        }
        
        public void ExceptDemo()
        {
            //no query syntax
            IList<Employee> empList = InitializeEmployee();
            IList<string> empNames = new List<string>
                                    { "Praveen", "Ranjith" };
            IEnumerable<string> eExcept = empList
                         .Where(x => x.Department == "Accounts")
                         .Select(e=>e.EmpName).Except(empNames);
            //Priya,Praveen,Ranjith Except Praveen Ranjith
            foreach (var s in eExcept)
                Console.WriteLine(s);
        }
        public void UnionDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IList<string> empNames = new List<string> { "Praveen", "Ranjith","Divya" };
            IEnumerable<string> eUnion = empList
                .Where(x => x.Department == "Purchase")
                .Select(e => e.EmpName).Union(empNames);
            foreach (var s in eUnion)
                Console.WriteLine(s);

            //lavanya,Divya union Praveen Ranjith,Divya
            //no duplicate in output
        }
        public void IntersectDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IList<string> empNames = new List<string> 
                                { "Praveen", "Ranjith","Divya"};
            IEnumerable<string> eIntersect = empList
                .Where(x => x.Department == "Accounts")
                .Select(e => e.EmpName).Intersect(empNames);
            foreach (var s in eIntersect)
                Console.WriteLine(s);

            //Priya, Praveen,Ranjith intersect Praveen,Ranjith,Divya
        }
        public void ContainsDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            bool eContains = empList
                .Where(x => x.Department == "Accounts")
                .Select(e => e.EmpName).Contains("Priya");
            Console.WriteLine(eContains);
            //priya=true divya=false
        }
        public void AllDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            bool eAll = empList
                .Select(e => e.Salary).All(x=>x>5000);
            Console.WriteLine(eAll);
            //5000 true  10000=false

        }
        public void AnyDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            bool eAny = empList
               .Select(e => e.Salary).Any(x => x > 30000);
            Console.WriteLine(eAny);
            //25000-true  30000-false
        }
        public void selectMAnyDemo()
        {
            IList<Employee> empList = InitializeEmployee();
            IEnumerable<string> eMany = from e in empList
                                        where e.Department == "Accounts"
                                        select e.EmpName;
            var eMethod = empList.Where(x => x.Department == "Accounts").SelectMany(b => b.EmpName);

            foreach (var s in eMethod)
                Console.WriteLine(s);
        }
        //public void FirstOrDefaultDemo()
        //{
        //    IList<Employee> empList = InitializeEmployee();
        //    var ee = empList.FirstOrDefault(n => n.Salary > 30000);
        //    Console.WriteLine(ee);
//int QuerySyntax = (from num in numbers
                            //   select num).First(num => num % 2 == 0);


    }
}
