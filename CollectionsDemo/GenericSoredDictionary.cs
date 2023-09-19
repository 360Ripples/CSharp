namespace CollectionsDemo
{
    public class GenericSortedDictionary
    {
        // Storing data in sorted way based on keys
        // Here country are sorted based on country length
        public void StoreStringDataSortedOrder()
        {
            // Adding Elements
            // IMPORTANT :Always declare variables with interfaces
            IComparer<string> cmp = new CountryComparer();
            IDictionary<String, String> table = new SortedDictionary<String, String>(cmp);

            table.Add("India", "New Delhi");
            table.Add("China", "Beijing");
            table.Add("Russia", "Moscow");
            table.Add("USA", "Washington");
           

            table.Add("Cambodia", "Phnom Penh");
            // Printing values in the table as rows and columns
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (KeyValuePair<String, String> entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }
        }

        // Dictionary  with key as integer and value as objects
        // Rows are sorted based on employee ID's
        public void StoreEmployeeDetails()
        {
            // IMPORTANT :Always declare variables with interfaces
            IComparer<int> cmp = new EmployeeIDComparer();
            IDictionary<int, Employee> table = new SortedDictionary<int, Employee>(cmp);
            Employee obj1 = new Employee();
            obj1.Salary = 20000;
            obj1.IsCitizen = false;
            obj1.Name = "Jill";
            obj1.Id = 5110;

            Employee obj3 = new Employee();
            obj3.Salary = 30000;
            obj3.IsCitizen = false;
            obj3.Name = "Tom";
            obj3.Id = 5114;


            Employee obj4 = new Employee();
            obj4.Salary = 30000;
            obj4.IsCitizen = false;
            obj4.Name = "John";
            obj4.Id = 5113;


            Employee obj2 = new Employee();
            obj2.Salary = 30000;
            obj2.IsCitizen = false;
            obj2.Name = "Jack";
            obj2.Id = 5111;

            table.Add(obj1.Id, obj1);
            table.Add(obj4.Id, obj4);
            table.Add(obj3.Id, obj3);
            table.Add(obj2.Id, obj2);


            // iterating through opbjects
            Console.WriteLine("Employees Details {0}", table.Count);
            DisplayEmployees(table);


        }

        private static void DisplayEmployees(IDictionary<int, Employee> table)
        {
            foreach (KeyValuePair<int, Employee> row in table)
            {
                Console.WriteLine("Key: {0}, Value: {1}",

                    row.Key, row.Value);
            }
        }



    }
}
