using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectDemo
{
    internal class LinqStudent
    {
        public IList<Student> InitializeStudent()
        {
            Student s1 = new Student
            {
                Id = 1,
                Name = "Bala",
                Marks = 89,
                City = "Chennai"
            };
            Student s2 = new Student
            {
                Id = 2,
                Name = "Ramya",
                Marks = 65,
                City = "Coimbatore"
            };
            Student s3 = new Student
            {
                Id = 3,
                Name = "Preethi",
                Marks = 77,
                City = "Chennai"
            };
            Student s4 = new Student
            {
                Id = 4,
                Name = "Gayathri",
                Marks = 78,
                City = "Coimbatore"
            };
            Student s5 = new Student
            {
                Id = 5,
                Name = "Keerthi",
                Marks = 66,
                City = "Chennai"
            };
            Student s6 = new Student
            {
                Id = 6,
                Name = "Swetha",
                Marks = 88,
                City = "Trichy"
            };
            Student s7 = new Student
            {
                Id = 7,
                Name = "Sri",
                Marks = 94,
                City = "Banglore"
            };
            Student s8 = new Student
            {
                Id = 8,
                Name = "Yash",
                Marks = 74,
                City = "Thiruvallur"
            };
            IList<Student> studentList=new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);
            studentList.Add(s6);
            studentList.Add(s7);
            studentList.Add(s8);
            return studentList;
        }
    }
}
