using System;
namespace CSharpProjectDemo
{
	internal class Employee
	{
		private int empId;

		public int EmpID
		{
			get { return empId; }
			set { empId = value; }
			
		}
		private string empName;
		public string EmpName
		{
			get { return empName; }
			set { empName = value; }
		}
		private int salary;

		public int Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		private string department;

		public string Department
		{
			get { return department; }
			set { department = value; }
		}

        public override string? ToString()
        {
			return "Employee Id=" + EmpID + " name=" + empName + " salary=" + salary + " department=" + department;
        }
    }
}
