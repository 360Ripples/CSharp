using System;
namespace CSharpProjectDemo
{
    public class OverloadingDemo
    {
        public void Print(int num1)
        {
            Console.WriteLine("Method 1 "+num1);
        }
        public void Print(int n1,int n2)
        {
            Console.WriteLine(n1+n2+"Method 2 ");
        }
        public void Print(int n1,int n2,int n3)
        {
            Console.WriteLine("MEthod 3 "+n1 + n2 + n3);
        }
    }
}