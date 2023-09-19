namespace CSharpProjectDemo
{
    internal class ConstructorDemo
    {

        int StudentId;
        string StudentName = null;
        // Default constructor
        public ConstructorDemo()
        {
            Console.WriteLine("Default constructor invoked****");
        }

        // The following are example of overloaded constructor
        public ConstructorDemo(int studentId)
        {
            StudentId = studentId;
            Console.WriteLine("Int param constructor invoked****");
        }

        public ConstructorDemo(string studentName)
        {
            StudentName = studentName;
            Console.WriteLine("String param constructor invoked****");
        }

        // Example of chaining one cosntructor. Cannot chain two different constructors
        public ConstructorDemo(int studentId, string studentName) : this(studentId)
        {
            // First the int param constructor will be 
            // invoked  in the method signature this(studentId),
            // followed by the below statements 
            Console.WriteLine("String Int param constructor invoked****");
            StudentName = studentName;

        }

        // This is called a copy constructor where the objects can be cloned.
        public ConstructorDemo(ConstructorDemo o)
        {
            StudentId = o.StudentId;
            StudentName = o.StudentName;
        }

        public override string ToString()
        {
            return $"Object Values --> {StudentId} {StudentName}";
        }

        // Static constructors can be used to instantiate the static values
        // They cannot be parameterized 
        // Cannot initialize non static variables
        // Can be only one static constructor.
        // Cannot be invoked explicitly
        // Static constructor will be invoked first followed by default constructor.
        //static ConstructorDemo()
        //{
        //    Console.WriteLine("Static constructor invoked****");
        //}
        
        ~ConstructorDemo()
        {
            Console.WriteLine("Destructor executed");
        }
    }
}
