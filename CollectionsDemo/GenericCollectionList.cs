namespace CollectionsDemo
{
    public class GenericCollectionList
    {
        public IList<string> StoreList()
        {
            // can store duplicates. 
            // IMPORTANT :Always declare variables with interfaces
            IList<string> list = new List<string>();
            list.Add("India");
            list.Add("USA");
            list.Add("China");
            list.Add("Russia");
            list.Add("China");
            DisplayCountries(list);
            
            return list;
            // List donw the countries with alphabet A
            // This is example of Linq
            //List<string> countries = list.Where(x => x.Contains("a")).ToList();
            //Console.WriteLine("\nCountries with alphabet A");
            //DisplayCountries(countries);
        }


        public void StoreHashSet()
        {
            // cannot store duplicates
            ISet<string> list = new HashSet<string>();
            list.Add("India");
            list.Add("USA");
            list.Add("China");
            list.Add("Russia");
            list.Add("China");
            
            Console.WriteLine("\nHashSet -->Countries Duplicates Removed");
            DisplayCountries(list);

        }

        public void StoreSortedSet()
        {
            // cannot store duplicates at the same time the values will be sorted
            // IMPORTANT :Always declare variables with interfaces
            ISet<string> list = new SortedSet<string>();
            list.Add("India");
            list.Add("USA");
            list.Add("China");
            list.Add("Russia");
            list.Add("China");
            Console.WriteLine("\nSortedSet ---> Countries Duplciates Removed and Sorted");
            DisplayCountries(list);
        }

        //Store countries sorted based on the country name length
        public void StoreCountryNameSortedSet()
        {
            // cannot store duplicates at the same time the values will be sorted
            // based on length of String
            IComparer<string> cmp = new CountryComparer();
            ISet<string> list = new SortedSet<string>(cmp);
            list.Add("Indonesia");
            list.Add("USA");
            list.Add("Germany");
            list.Add("China");

            Console.WriteLine("\nSortedSet with Comparer--> Countries sorted  based on  length of string ");
            DisplayCountries(list);
        }

        //Store employees sorted based on salary
        public void StoreEmployeeSortedSet()
        {
            Employee obj1 = new Employee();
            obj1.Salary = 20000;
            obj1.IsCitizen = false;
            obj1.Name = "Jill";
            obj1.Id = 5110;

            Employee obj2 = new Employee();
            obj2.Salary = 60000;
            obj2.IsCitizen = false;
            obj2.Name = "Jack";
            obj2.Id = 5111;

            Employee obj3 = new Employee();
            obj3.Salary = 30000;
            obj3.IsCitizen = false;
            obj3.Name = "Tony";
            obj3.Id = 5112;


            Employee obj4 = new Employee();
            obj4.Salary = 90000;
            obj4.IsCitizen = false;
            obj4.Name = "Mary";
            obj4.Id = 5113;

            IComparer<Employee> comparer = new EmployeeComparer();
            // Stored by sorting by salary
            // IMPORTANT :Always declare variables with interfaces
            ISet<Employee> list = new SortedSet<Employee>(comparer);
            // The below code will give a runtime exception since it does not know how to 
            // sort the custom objects
            //ISet<Employee> list = new SortedSet<Employee>();
            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            Console.WriteLine("\nSortedSet With Comparer--> sorted based on salary");
            DisplayEmployees(list);

        }



        private static void DisplayCountries(ICollection<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Country: {0}", item);
            }
        }

        private static void DisplayEmployees(ICollection<Employee> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Employee: {0}", item);
            }
        }
    }
}
