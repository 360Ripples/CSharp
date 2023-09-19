using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectDemo
{
    internal class NamedAndOptionalParamters
    {
        public void display(int a,int b)
        {
            Console.WriteLine("The values are " + a + " and " + b);
        }
        public void display2(int x,int y=200)
        {
            Console.WriteLine("The values are " + x + " and " + y);
        }
    }
}
