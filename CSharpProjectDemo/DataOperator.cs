namespace CSharpProjectDemo
{
    internal class DataOperators
    {
        int a = 10;
        int b = 20;


        public void operatorDemo()
        {
            //arithmetic binary operators
            int c = a + b;
            c = a * b;
            c = a - b;
            c = a % b;
            c = a / b;

            //Unary operator 
            c = ++a;
            c = a++;

            //assignment operator 
            a += b; // Equivalent to a = a+b



            //ternary operator
            c = a > b ? a : b;


            //logical operator
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = flag1 && flag2;
            flag3 = flag1 || flag2;
            flag3 = !flag1;


            // Relational operator

            flag3 = a > b;
            flag3 = a >= b;
            flag3 = a < b;
            flag3 = a <= b;

            //Bit wise operator
            c = a & b;
            c = a | b;
            c = a ^ b;

            // Shift operator
            c = a >> b;
            c = a << b;
            




        }




    }
}
