namespace OOPSDemo
{
    // This is the abstract implementation class
    internal abstract class AbstractClassImpl : AbstractClassDemo
    {
        // Abstract method  overriden from the parent abstract class      
        public override int Subtract(int a, int b)
        {
            return a - b;
        }

        // This class then defines another abstract method
        public abstract int Add(int a, int b);
    }
    // This class extends the abstract class 
    internal class AbstractClassImpl1 : AbstractClassImpl
    {

        // This should implement the abstract method add
        public override int Add(int a, int b)
        {
            return a + b;
        }
    }
    


}
