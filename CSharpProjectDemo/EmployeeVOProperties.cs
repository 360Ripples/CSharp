namespace CSharpProjectDemo
{
    internal class EmployeeVOProperties
    {

        // Four types of properties;
        //1. Read only
        //2. Write only
        //3  Read - Write
        //4. Auto implemented property 

        // Example of a write only property only setter
        private string _empName = null;
        // Example of a read only property only geter
        private int _age = 0;
        // Example of a read write only property
        private string _email;
        // Example of assymetric accessors
        private bool _gender;
        // Auto implemented property
        private long _mobileNumber;

        // Example of getter and setter
        private string _employeeId;

        // Write only property
        public string EmpName
        {
            set
            {
                _empName = value;
            }
        }

        //Read only property
        public int Age
        {
            get
            {
                return _age;
            }
        }

        //Read Write only property
        public string Email
        {
            get
            {
                // You can write some logic in processing the value before
                // it is returned
                _email = _email.ToLower();
                return _email;
            }
            set
            {
                // You can write some logic when setting the value
                _email = value + ".com";
            }
        }

        // Assymmetric accessors - this happens if the access specifiers are different
        // for the setter and getter. Note only one accessors can be specified with
        // the access specifier. Als the access specifier of the accessor should be
        // restrictive than the Gender class

        public bool Gender
        {
            protected get
            {
                return _gender;
            }
            set //is public by default
            {
                _gender = value;
            }
        }

        //Auto implemented properties are used if you dont have any logic when setting 
        // or getting the property.. Inntroduced in C# 3.0

        public long MobileNumber { set; get; }



        //Traditional getter and setter
        public string GetEmployeeId()
        {
            return _employeeId;
        }

        public void SetEmployeeId(string empId)
        {
            _employeeId = empId;
        }

        // to string method overridden 
        public override string ToString()
        {
            return $"{{ {nameof(Age)}={Age.ToString()}, {nameof(Email)}={Email}, {nameof(Gender)}={Gender.ToString()}, {nameof(MobileNumber)}={MobileNumber.ToString()}}}";
        }

        // Overridden equals method to check only the emp names
        // if same consider the employees as equal
        //public override bool Equals(object? obj)
        //{
        //    return obj is EmployeeVOProperties properties &&
        //           _empName == properties._empName;
        //}

    }
}
