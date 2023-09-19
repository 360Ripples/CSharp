namespace CSharpProjectDemo
{
    internal class LoopDemo
    {
        public void ForLoopDemo()
        {
            Console.WriteLine("For Loop Demo");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void WhileLoopDemo()
        {
            Console.WriteLine("While Loop Demo");
            int i = 0;
            while (i < 10)
            {
                if(i==5)
                {
                   return;
                }
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Loop ended");
        }

        public void DoWhileLoopDemo()
        {
            Console.WriteLine("DO While Loop Demo");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }
    }
}
