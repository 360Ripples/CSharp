namespace OOPSDemo
{
    public class BaseClass
    {
        int id = 100;

        // Virtual keyword is used to mark a method as overridable
        // This is callled overriden method
        public virtual void Add(int a, int b)
        {
            Console.WriteLine("Base class add method trigerrrrrrrred");
        }

        public virtual void Subtract(int a, int b)
        {
            Console.WriteLine("Base class subtract method trigerred");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Parent  class multiply method trigerred");
        }

        public virtual void Mod(int a, int b)
        {
            Console.WriteLine("Parent  class Mod method trigerred");
        }


    }
    // SEALED CLASS
    // A sealed class cannot be inherited
    // A sealed class cannot have abstract methods
    // SEALED METHOD
    // By default all methods are sealed, it cannot be overriden unless marked as virtual
    // Mod method in base class is virtual and in child class it is sealed and overriden
    // In the sub class of child class we cannot override the mehtod Mod
    public sealed class ChildClass : BaseClass
    {
        //  use override keyword to override  abase class method
        // This is callled oveerdiding method
        public override void Add(int a, int b)
        {
            Console.WriteLine("Child class add method trigerred");
        }

        // This is not a overrriden method
        public void Subtract(int a, int b)
        {
            // used to invoke the base class method
            //base.Subtract(a, b);
            Console.WriteLine("Child class subtract method trigerred");
        }

        public new void Multiply(int a, int b)
        {
            Console.WriteLine("Child class multiply method trigerred");
        }


        public override sealed void Mod(int a, int b)
        {
            Console.WriteLine("Child class multiply method trigerred");
        }

    }
    // If the Child class is marked as Sealed the below inheritance is not possible
    //public class ChildClass1 : ChildClass

    //{
    //    // since it is sealead it cannot be overriden
    //    public override sealed void Mod(int a, int b)
    //    {
    //    }
    //}

    public class OverloadingClass
    {
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Invoked the Two argument method");
        }

        public void Subtract(int a, int b, int c)
        {
            Console.WriteLine("Invoked the three argument method");
        }

    }
}
