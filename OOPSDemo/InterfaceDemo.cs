namespace OOPSDemo
{
    public interface InterfaceDemo
    {        
        // All methods are by default abstract and public
        // Cannot have non abstract methods
        // Cannot be instantiated
        // Interfaces cannot have instance variables, constructors,destructors and static methods
        // Class can inherit multiple interfaces
        // Interface can extend one or more interfaces
        void Add();
    }

    public interface InterfaceDemo1
    {
      void display()
        {

        }
       void Subtract();
    }

    public interface InterfaceDemo2 : InterfaceDemo1, InterfaceDemo
    { 
        void Subtract()
        { }
        void Multiply();
    }
}
