using System.Collections;

namespace CollectionsDemo
{
    public class NonGenericHashTable
    {
        // Hashtable stores value in key value pair
        // String/ String
        public void DemoTableString()
        {
            Console.WriteLine();
            Console.WriteLine("HASH TABLE");
            // Adding Elements
            Hashtable table = new Hashtable();
            table.Add("India", "New Delhi");
            table.Add("China", "Beijing");
            table.Add("Russia", "Moscow");
            table.Add("USA", "Washington");
            //table.Add(null, "wdefr");  //key cannot be null
            table.Add("ttt", "Moscow");   //value can be duplicate
            //table.Add("ttt", "una");    //key cannot be duplicate
            table.Add("Japan", null);      //value can be null
            table.Add("Sweden", null);   //value can have more than one null
           // table.Add(1, "Fds");     //accepted
           
           Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }
            // Fetching elements based on Key
            Console.WriteLine("Capital of USA is {0}", table["USA"]);

            //Checks if the key is present in the given HashTable
            Console.WriteLine("Is India present in the table data {0}", table.ContainsKey("India"));

            //Checks if the value is present in the given HashTable
            Console.WriteLine("Is Moscow present in the table data {0}", table.ContainsValue("Moscow"));

            // Removing a row
            table.Add("Cambodia", "Phnom Penh");
            table.Remove("China");
            Console.WriteLine("Removed China from table -->{0}", table.ContainsKey("China"));
                
            // Printing values in the table as rows and columns
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }
            //Updating the capital
            table["China"] = "Wuhan";
            // Iterate through all keys and display the values
            foreach (string key in table.Keys)
            {
               Console.WriteLine("Value {0}", table[key]);
            }

        }
        // Hashtable with key as integer and value as objects
        public void StoreEmployeeDetails()
        {
            Hashtable table = new Hashtable();
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
            
            //table.Add(obj1.Id, obj2);// RT Error thrown as the same key exist.

            //table[obj1.Id] = obj2; // To update the value

            // iterating through opbjects
            Console.WriteLine("Employees Details");
            
            
            DisplayEmployees(table);

            // Iterating Employees and if salary above 20000
            // set the istaxable falg as true
            // The employees inside the table will be updated
            foreach (DictionaryEntry de in table)
            {
                Employee e = (Employee)de.Value;
                if (e.Salary > 20000)
                {
                    e.IsSalaryTaxable = true;
                }

            }
            Console.WriteLine("********Employees Details After Update********");
            DisplayEmployees(table);
            Console.WriteLine("===========Employee Details Completed========================\n");
        }
        // Hashtable with key as integer and value as list of objects
        public void StoreEmployeeRoleDetails()
        {
            Hashtable table = new Hashtable();
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


            ArrayList developerList = new ArrayList();
            developerList.Add(obj1);
            developerList.Add(obj2);

            ArrayList managerList = new ArrayList();
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
        private static void DisplayEmployees(Hashtable table)
        {
            foreach (DictionaryEntry d in table)
            {
                Console.WriteLine("ID " + d.Key + " VLAUE " + d.Value);
            }

            //foreach (DictionaryEntry de in table)
            //{
            //    Employee e = (Employee)de.Value;
            //    Console.WriteLine("ID:{0} Value:{1}", e.Id, e);
            //}
        }

        private static void DisplayEmployeesBasedOnRoles(Hashtable table)
        {
            foreach (DictionaryEntry de in table)
            {
                ArrayList employeeList = (ArrayList)de.Value;
                foreach (Employee employee in employeeList)
                {
                    Console.WriteLine("ID:{0} Value:{1}", employee.Id, employee);
                }
            }
        }
        // If salary > 50K role shoudl be manager
        private static void UpdateEmployeesRoles(Hashtable table)
        {
            foreach (DictionaryEntry de in table)
            {
                ArrayList employeeList = (ArrayList)de.Value;
                foreach (Employee employee in employeeList)
                {
                    if (employee.Salary >= 50000)
                        employee.IsManager = true;
                }
            }
        }
    }
}
