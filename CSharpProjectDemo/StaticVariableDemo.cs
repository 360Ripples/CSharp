using System.Security.Cryptography.X509Certificates;

namespace CSharpProjectDemo
{
    internal class StaticVariableDemo
    { 
        // static variables exists till the application scope
        // and they are deleted from the memory only when the application stops
        // And it is shared by all the object instances of the StaticVariableDemo class

        public static int x = 100;
        public int y = 200;

        //value cannot be changed and it should be initalized
        const int z = 999;
         

        //value need not be initialized. Once initialized it cannot be changed
        // to be initialized inside a constructor 
        readonly int m;

        public void staticDemo()
        {
            Console.WriteLine("Static variable X--->" + x);
            Console.WriteLine("Non Static variable Y--->" + y);
        }

        public void constantDemo()
        {
            // This will throw an error since it is constant and cannot be changed
            //z = 1000;
            Console.WriteLine("Read only value-->" + m);
            // Readonly values can be intialized only when the object is created in construtor
            // so the following code throws and error
            // m = 777;

        }

        public StaticVariableDemo(int k)
        {
            // read only fields can be initialzed during instantiation
            m = k;
        }

        // A demo of static method and how it can be invoked without object instantiation
        public static void DisplayMessage()
        {
            Console.WriteLine("****** Static method trigerred *****");
        }

    }
}
