using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo;

//Lambda expressions are similar to anonymous methods introduced in C# 2.0
//Use Lambda whenever you feel you can reduce your lines of code.   
//Lambda Expressions can be used to simply replacing Anonymous functions,
//In the LINQ query methods, or anywhere you have to initialize Generic delegates. 
public class LambdaDemo
{
    public void DemoLambda()
    {
        GenericCollectionList l = new GenericCollectionList();
        List<String> list = (List<string>)l.StoreList();
        //List<int> l1 = null;

        var dem = () => { Console.WriteLine("Hello World"); };
        //li
        
        // Simple lambda expression to check if all strings in a list contains a letter A
        bool flag = list.All((a) => a.Contains("a") || a.Contains("A"));
        
        string result = flag ? "All countries has charachter a or A" : "All countries does not have charachter a or A";
        Console.WriteLine(result);

        // Filter all the countries which contains the text a
        List<String> filteredList = list.FindAll((a) => a.Contains("r") || a.Contains("R"));
        filteredList.ForEach((a) => { Console.WriteLine(a); });

        // Filter all the employees whose salary is > 40000
        List<Employee> empList = StoreEmployeeList();
        List<Employee> filteredEmpList = empList.FindAll((a) => a.Salary > 40000);
        filteredEmpList.ForEach((a) => Console.WriteLine(a));


        //Group by country
        Console.WriteLine("--Group by Country--");
        var empCountryGroup = empList.GroupBy((a) => a.Country);
        double averageSalary;
       
        foreach (var empGroup in empCountryGroup)
        {
            Console.Write("Emp Country::" + empGroup.Key + "\n");
            foreach (var emp in empGroup)
            {
                Console.WriteLine(emp);
            }
            averageSalary = empGroup.Average(a => a.Salary);
            Console.WriteLine("Emp Average Salary for Country::{0} is {1}", empGroup.Key, averageSalary);
        }
        //Calculate average salary of employees
        averageSalary = empList.Average(a => a.Salary);
        Console.WriteLine("Emp Average Salary across all countries::" + averageSalary);

        double maxSalary = empList.Max(a => a.Salary);
        Console.WriteLine("Max Salary of Employee=" + maxSalary);

    }




    public List<Employee> StoreEmployeeList()
    {
        Employee obj1 = new Employee();
        obj1.Salary = 20000;
        obj1.IsCitizen = false;
        obj1.Name = "Jill";
        obj1.Id = 5110;
        obj1.Country = "UK";

        Employee obj2 = new Employee();
        obj2.Salary = 60000;
        obj2.IsCitizen = false;
        obj2.Name = "Jack";
        obj2.Id = 5111;
        obj2.Country = "India";

        Employee obj3 = new Employee();
        obj3.Salary = 30000;
        obj3.IsCitizen = false;
        obj3.Name = "Tony";
        obj3.Id = 5112;
        obj3.Country = "India";


        Employee obj4 = new Employee();
        obj4.Salary = 90000;
        obj4.IsCitizen = false;
        obj4.Name = "Mary";
        obj4.Id = 5113;
        obj4.Country = "Russia";

        Employee obj5 = new Employee();
        obj5.Salary = 100000;
        obj5.IsCitizen = false;
        obj5.Name = "Chov";
        obj5.Id = 5114;
        obj5.Country = "Russia";

        List<Employee> list = new List<Employee>();
        list.Add(obj1);
        list.Add(obj2);
        list.Add(obj3);
        list.Add(obj4);
        list.Add(obj5);
        return list;
    }

}
