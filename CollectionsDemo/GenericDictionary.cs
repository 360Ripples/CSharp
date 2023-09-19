namespace CollectionsDemo
{
    public class GenericDictionary
    {

        public void StoreStringData()
        {
            // Adding Elements
            // IMPORTANT :Always declare variables with interfaces
            Dictionary<String, String> table = new Dictionary<String, String>();
            table.Add("India", "New Delhi");
            table.Add("China", "Beijing");
            table.Add("Russia", "Moscow");
            table.Add("USA", "Washington");
            //Console.WriteLine(table);
            // Fetching elements based on Key
            Console.WriteLine("Capital of USA is {0}", table["USA"]);

            //Checks if the key is present in the given Dictionary
            Console.WriteLine("Is India present in the table data {0}", table.ContainsKey("India"));

            //Checks if the value is present in the given Dictionary
            Console.WriteLine("Is Moscow present in the table data {0}", table.ContainsValue("Moscow"));

            // Removing a row
            table.Add("Cambodia", "Phnom Penh");
            table.Remove("China");
            Console.WriteLine("Removed China from table -->{0}", table.ContainsKey("China"));

            // Printing values in the table as rows and columns
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (KeyValuePair<String, String> entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }
            //Updating the capital using the indexer method
            table["China"] = "Wuhan";
            // Iterate through all keys and display the values
            foreach (string key in table.Keys)
            {
                Console.WriteLine("Values {0}", table[key]);
            }

        }

        // Dictionary  with key as integer and value as objects
        public void StoreEmployeeDetails()
        {
            // IMPORTANT :Always declare variables with interfaces
            IDictionary<int, Employee> table = new Dictionary<int, Employee>();
            Employee obj1 = new Employee();
            obj1.Salary = 20000;
            obj1.IsCitizen = false;
            obj1.Name = "Jill";
            obj1.Id = 5110;

            Employee obj2 = new Employee();
            obj2.Salary = 30000;
            obj2.IsCitizen = false;
            obj2.Name = "Jack";
            obj2.Id = 5111;

            table.Add(obj2.Id, obj2);
            table.Add(obj1.Id, obj1);

            //table.Add(obj1.Id, obj2);// Error thrown as the same key exist.

            //table[obj1.Id] = obj2; // To update the value

            Console.WriteLine("Employees Details");
            DisplayEmployees(table);

            // Iterating Employees and if salary above 20000
            // set the istaxable flag as true
            // The employees inside the table will be updated
            foreach (int de in table.Keys)
            {
               // Employee e = (Employee)table[de];
                Employee e = table[de];
                if (e.Salary > 20000)
                {
                    e.IsSalaryTaxable = true;
                }

            }
            Console.WriteLine("********Employees Details After Update********");
            DisplayEmployees(table);
            Console.WriteLine("===========ENDED=================");
        }

        // Hashtable with key as integer and value as list of objects
        public void StoreEmployeeRoleDetails()
        {
            // IMPORTANT :Always declare variables with interfaces
            IDictionary<String, IList<Employee>> table = new Dictionary<string, IList<Employee>>();
            Employee obj1 = new Employee();
            obj1.Salary = 20000;
            obj1.IsCitizen = false;
            obj1.Name = "Jill";
            obj1.Id = 5110;

            Employee obj2 = new Employee();
            obj2.Salary = 30000;
            obj2.IsCitizen = false;
            obj2.Name = "Jack";
            obj2.Id = 5111;

            Employee obj3 = new Employee();
            obj3.Salary = 60000;
            obj3.IsCitizen = false;
            obj3.Name = "Tony";
            obj3.Id = 5112;


            Employee obj4 = new Employee();
            obj4.Salary = 90000;
            obj4.IsCitizen = false;
            obj4.Name = "Mary";
            obj4.Id = 5113;


            IList<Employee> developerList = new List<Employee>();
            developerList.Add(obj1);
            developerList.Add(obj2);

            IList<Employee> managerList = new List<Employee>();
            managerList.Add(obj3);
            managerList.Add(obj4);

            table.Add("Manager", managerList);
            table.Add("Developer", developerList);

            DisplayEmployeesBasedOnRoles(table);

            // Update Manager Role based on salary
            UpdateEmployeesRoles(table);
            Console.WriteLine("********Employees Details After Role Update********");
            DisplayEmployeesBasedOnRoles(table);
        }

        private static void DisplayEmployees(IDictionary<int, Employee> table)
        {
            foreach (int e in table.Keys)
            {
                // Employee emp = (Employee)table[e];
                Employee emp = table[e];
                Console.WriteLine("ID:{0} Value:{1}", emp.Id, emp);
            }
        }

        // If salary > 50K role should be manager
        private static void UpdateEmployeesRoles(IDictionary<String, IList<Employee>> table)
        {
            foreach (string e in table.Keys)
            {
                //IList<Employee> employeeList = (List<Employee>)table[e];
                IList<Employee> employeeList = table[e];
                foreach (Employee employee in employeeList)
                {
                    if (employee.Salary >= 50000)
                        employee.IsManager = true;
                }
            }
        }
        private static void DisplayEmployeesBasedOnRoles(IDictionary<String, IList<Employee>> table)
        {
            foreach (String e in table.Keys)
            {
                DisplayEmployeeList(table[e]);
            }
        }


        private static void DisplayEmployeeList(IList<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine("ID:{0} Value:{1}", employee.Id, employee);
            }
        }
    }
}
