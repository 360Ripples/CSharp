namespace OOPSDemo
{
    public abstract class AbstractClassDemo
    {
        //abstract class rules: 1. Abstract class can have zero abstract method
        //2. Abstract class needs to be declared abstract
        //3. Abstract methods needs to be declared abstract
        //4. Abstract class can be a mix of abstract and non abstract methods.

        // Member variable
        int age = 10;
       // non abstract method
        //public void Add(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        // Abstract method
        public abstract int Subtract(int a, int b);


    }
}
