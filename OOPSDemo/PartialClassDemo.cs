namespace OOPSDemo
{
    // Partial classes are used by developer to implement the same class
    // in the same name space.In large projects developers can work on the same class parallelly
    // In turn the compiler will clube all the partial classess of the same type into one entity
    // 
    public abstract partial class PartialClassDemo : BaseClass
    {
        public void Add()
        {
            Console.WriteLine("Add method in partial class");
        }

        public abstract void multiply();

        // PARTIAL METHODS
        // Partial methods are methods which are declared without implementations
        // During compile time the compiler if it finds it is not defined in
        // any of the class it will be knocked off from the class. Check ILDASM
        // 1. Partial emthod are private by default.
        // 2. Partial method declaration and implementation cannot be in the same partial class
        // 3. Partial method cannot have return types it should be void.
        //    If you want to specify any return type change the
        //    access modifiers to either public or protected from private.
        // 4. Partial method can be present in partial classess alone.
        // 5. Partial method signature of declaration and implementation should be same.
        // 6. Partial methods can be implemented only once in one of the partial classes
        // 7. 

        partial void Divide();
        
        
    }

    // The partial class developed below can be in a different physical CS file too
    // But the method names in the class cannot be same, after the below class files
    // is compiled the Csharp compielr will place all the methods in one logical unit
    // you can check this with the ILDASM tool
    // 1. Partial class should have the same access modifiers across.
    // 2. A class defined as partial if defined again
    // needs to be marked as partial
    // 3. If any part of the partial class is
    // declared abstract it cannot be instantiated
    // 4. Partial classes across cannot inherit two different base classes, but one partial class
    // can inherit one base class and other need not implement any class
    // 5. But partial classes can inherit different interfaces.

    public partial class PartialClassDemo
    {
        //Not allowed same method name 
        //public void Add()
        //{

        //}
        public void Subtract()
        {
            Console.WriteLine("Add method in partial class");
        }

        // Partial methods is defined here

        partial void Divide()
        {
            Console.WriteLine("Divide method in Partial class");
        }

    }
    //internal class AD:PartialClassDemo
    //{
    //    //Error to give implementation for abstract method
    //    //multiply()
    //}
    
}
