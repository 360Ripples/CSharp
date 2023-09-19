namespace CSharpProjectDemo
{
    internal class DecisionStatements
    {
        public void ifElseDemo()
        {
            int a = 20;
            int b = 30;
            if (a > b)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("B is greater than A");
            }
        }

        public void ifElseIFDemo()
        {
            int a = 20;
            int b = 30;
            int c = 40;
            if (a > b && a > c)
            {
                Console.WriteLine("A is greater than B/C");
            }
            else if (b > c)
            {
                Console.WriteLine("B is greater than A/C");
            }
            else
            {
               Console.WriteLine("C is greater than A/B");
            }
        }

        public void ifElseNestedDemo()
        {
            int a = 70;
            int b = 70;
            int c = 70;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greater than B/C");
                }
                else
                {
                    Console.WriteLine("C is greater than A/B");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("B is greater than A/C");
            }
            else if (c == a && a == b)
            {
                Console.WriteLine("A/B/C are same");
            }
            else
            {
                Console.WriteLine("C is greater than A/B");
            }
        }

        // Case can be string, int or enums
        public void SwitchDemo()
        {
            int a = 2;
            switch (a)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                default:
                    Console.WriteLine("Default Month");
                    break;
            }



        }
    }



}
