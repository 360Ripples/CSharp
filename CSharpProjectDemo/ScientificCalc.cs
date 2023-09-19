using System;
namespace CSharpProjectDemo
{
    internal class ScientificCalc : Calc
    {
        public override void Add()
        {
            // base.Add();
            Console.WriteLine("Scientific Addition");
        }

        public void Sqroot()
        {
            Console.WriteLine("SQUARE ROOT");
        }
        public void Sin()
        {
            Console.WriteLine("SIN");
        }
    }
}
