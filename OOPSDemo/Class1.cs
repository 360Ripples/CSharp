using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class Class1
    {
        public virtual void a()
        {
            Console.Write("Class1");
        }
    }
    public class Class2 : Class1
    {
        public override void a()
        {
            Console.Write("class2");
        }
    }
    public class Class3 : Class2
    {
        
        public override void a() { } 

    }
}

