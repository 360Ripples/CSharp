namespace OOPSDemo
{
    public class OperatorOverloadingDemo
    {   // Operator overloading is applied on a user defined Class
        // In this demo if the add operation is invoked on the OperatorOverloadingDemo
        // The instance variable a and b is added in a customized way , logic is below.
        // Binary,Unary,comparison operators can be overloaded
        // assignment logical operators cannot be overloaded
        int a, b;

        public OperatorOverloadingDemo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // Addition logical operator overloaded
        public static int operator +(OperatorOverloadingDemo o1, OperatorOverloadingDemo o2)
        {
            int result = o1.a * o2.b + o2.a * o1.b;
            return result;
        }

        // Equal to logical operator overloaded
        public static bool operator ==(OperatorOverloadingDemo o1, OperatorOverloadingDemo o2)
        {
            bool result = o1.a == o2.b && o2.a == o1.b;
            return result;
        }

        // IMPORTANT: if Equal to logical operator is overloaded
        // != to operator should be overloaded 
        public static bool operator !=(OperatorOverloadingDemo o1, OperatorOverloadingDemo o2)
        {
            bool result = o1.a != o2.b || o2.a != o1.b;
            return result;
        }
    }
}
