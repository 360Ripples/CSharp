using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class AutoMapperDemo
    {
        public void TraditionalMapper()
        {
            //Traditional Method for Mapping
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Deepika";
            emp.Salary = 20000;
            emp.IsManager = true;
            emp.IsSalaryTaxable = true;
            emp.IsCitizen= true;

            //Employee emp1 = new Employee
            //{
            //    Id = 1,
            //    Name = "Deepika",
            //    Salary = 20000,
            //    IsManager = true,
            //    IsSalaryTaxable = true,
            //    IsCitizen = true
            //};

            EmployeeDest empDest = new EmployeeDest();
            empDest.Id = emp.Id;
            empDest.Name= emp.Name;
            empDest.Salary = emp.Salary;
            empDest.IsSalaryTaxable = emp.IsSalaryTaxable;
            empDest.IsManager=emp.IsManager;
            empDest.IsCitizen=emp.IsCitizen;
            
            Console.WriteLine($"Employee Id ={empDest.Id}, Name={empDest.Name}, Salary={empDest.Salary}");
        }
        public static Mapper InitializeMapper()
        {
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<Employee, EmployeeDest>());

            //If properties in objects are different

            //var config2 = new MapperConfiguration(
            //    cfg =>
            //    {
            //        cfg.CreateMap<Employee, EmployeeDest>()
            //    .ForMember(dest => dest.Salary,
            //    act => act.MapFrom(src => src.Payment));
            //    });

            var mapper = new Mapper(config);
            return mapper;
        }
        public void AutoDemo()
        {
            Employee e = new Employee();
            e.Id = 22;
            e.Name = "Gayathri";
            e.Salary = 30000;
            e.IsManager = false;
            e.IsSalaryTaxable= false;
            e.IsCitizen = true;
            
            var mapper=InitializeMapper();
            //METHOD 1
            //var empAuto = mapper.Map<EmployeeDest>(e);
           //METHOD 2
            var empAuto = mapper.Map<Employee, EmployeeDest>(e);
            Console.WriteLine($"Employee Id={empAuto.Id}, Name={empAuto.Name}, Salary={empAuto.Salary}");

        }
    }
}
