using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class EmployeeDest
    {
        private int id;
        private string name;
        private double salary;
        private bool isCitizen;
        private bool isSalaryTaxable;
        private bool isManager;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public bool IsCitizen { get => isCitizen; set => isCitizen = value; }
        public bool IsSalaryTaxable { get => isSalaryTaxable; set => isSalaryTaxable = value; }
        public bool IsManager { get => isManager; set => isManager = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Salary)}={Salary.ToString()}, {nameof(IsCitizen)}={IsCitizen.ToString()},{nameof(IsSalaryTaxable)}={IsSalaryTaxable.ToString()},{nameof(IsManager)}={IsManager.ToString()}}}";
        }
    }
}
