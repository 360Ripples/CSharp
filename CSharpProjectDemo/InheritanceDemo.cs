namespace CSharpProjectDemo
{   // 1. Multiple inheritance is not possible
    // 2. Multi level inheritance is possible A>B>C
    // 3. Constructor chaining can be done
    // 4. Once a constructor is over loaded without the default constructor 
    // the default constructor cannot be used for instantiation
    // 5. The constructors can be overloaded
    // 6. Child cannot access the private members in the parent
    // 7. All classess inherit the System.Object system class which
    // has the equals,tostring emthods
    // 8. Parent class cannot access the members of child class.


    internal class A
    {
        //5.
        public A()
        {
            Console.WriteLine("Constructor A no param is invoked");
        }

        public A(int i)
        {
            Console.WriteLine("Constructor A is invoked");
        }

        public void M1()
        {
        }
    }

    internal class B : A //2
    {
        public B()
        {
            Console.WriteLine("Constructor B no param is invoked");
        }

        public B(int i) : base(i) //3.
        {
            Console.WriteLine("Constructor B is invoked");
        }
        public void M2()
        {
        }
    }

    internal class C : B
    {
        
        public C(int i) : base(i)
        {
            Console.WriteLine("Constructor C is invoked");
        }
    }

    public class D
    {
        public void InheritanceConstructorDemo()
        {
            //4. 
            //C c1 = new C();
            
            C c2 = new C(20); // This will invoke the constructor in the order A->B->C

            //9. We can instance of subclass and declare it to parent class
            //but we will be able to access only the parent class method
            A b1 = new B();
            b1.M1();
            //b1.M2();// Though the instance is created with the B class
            // still the M2 cannot be invoked since it is declared using A.

            //A a1 = new A();
            //B b2 = (B)a1; // Type casting A to B qil throw run time error
        }
    }

}
