namespace OOPSDemo
{
    // Interface extending another interface
    // Interface can extend any number of interfaces 
    public class InterfaceDemoImpl : InterfaceDemo, InterfaceDemo1
    {
        public void Add()
        {
            Console.WriteLine("Interface add method implemented");
        }

        public void Subtract()
        {
            Console.WriteLine("Interface add method implemented");
        }
    }
    // Class extending interfaces which in turn extending other interfaces should
    // implement all the methods in both the interfaces
    public class InterfaceDemoImpl1 : InterfaceDemo2
    {
        public void Add()
        {
            Console.WriteLine("Interface add method implemented");
        }

        public void Multiply()
        {
            Console.WriteLine("Interface Multiply method implemented");
        }

        public void Subtract()
        {
            Console.WriteLine("Interface Subtract method implemented");
        }
    }
}
