namespace CollectionsDemo
{
    public class EmployeeComparer : IComparer<Employee>
    {
        // Descending order of salary
        public int Compare(Employee a, Employee b)
        {
            if (a.Salary > b.Salary)
                return -1;
            else if (a.Salary <= b.Salary)
                return 1;       //change
            return 1;
        }
    }
    public class EmployeeIDComparer : IComparer<int>
    {
        // Descending order of employee id
        public int Compare(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a <= b)
            {
                return 1;
            }
            return 1;

        }
    }
    public class CountryComparer : IComparer<string>
    {
        // String displayed based on number of charecters in ascending order
        public int Compare(string a, string b)
        {
            if (a.Length < b.Length)
                return -1;
            else if (a.Length >= b.Length)
                return 1;
            return 1;
        }
    }
}
