public class CallByValueReferenceDemo
{
    public CallByValueReferenceDemo()
    {
    }

    // Demonstrates call by value where the method parameters are passed as value
    // An the value of c is not changed in the method which invoked this method
    public void callByValue(int a, int b, ref int c)
    {
        c = a + b;
        Console.WriteLine("Result={0}", c);
    }

    // Here the parameter though is a object the reference is passed as value and not
    // reference so even if the value is changed here we are changing the
    // reference passed as value to another value and not changing the value as such
    public void callByReferenceAsValue(String s)
    {
        s = "Tom";
        Console.WriteLine($"In call by reference as value  method Name {s}");
    }

    // Here the parameter is passed as reference so any change in the string s
    // should impact the value in the invoked method.
    public void callByReferenceAsReference(ref String s)
    {
        Console.WriteLine($"initial value of s={s}");
        s = "Potter";
        Console.WriteLine($"In call by refernce as ref method Name {s}");
    }
    public void callByOut(out int a)
    {
        
        a = 12;
        Console.WriteLine($"call by out inside method {a}");
    }
    public void callByParams(params int[] p)
    {
        foreach (int i in p)   //p=1,2,3;
            Console.WriteLine(i);
    }


}
