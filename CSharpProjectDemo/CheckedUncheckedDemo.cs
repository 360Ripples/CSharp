namespace CSharpProjectDemo
{
    internal class CheckedUncheckedDemo
    {
        public void add(int a, int b)
        {
            // when we add one to 2147483647
            // it returns -2147483648
            // which is unexpected as cause of data over flow in signed int it 
            // prints this negative value
            // to avoid this if you use checked key word it will throw an runtime error
            // rather than a unexpected result..The default compile/runtime
            // behaviour of arithmetic logics is unchecked 
            int c = (a - b);
            Console.WriteLine(c);
        }



    }
}
