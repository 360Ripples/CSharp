namespace CSharpProjectDemo
{
    internal class ConsoleDemo
    {
        public void consoleDemo()
        {

            int  n=Console.Read();
            Console.WriteLine(n);
            // sets the title with a name
            Console.Title = "Welcome to C# World!";
            // sets the bg and foreground color
           
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            // prints the value with a new line
            Console.WriteLine("Welcome to the console Demo!");
            // prints the value without a new line

            // Reads a line
            String s = Console.ReadLine();
            Console.WriteLine("Line read= " + s);

            // Reads a key till Y is entered            
            Console.WriteLine("Enter Y to exit");
           
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key != ConsoleKey.Y)
                {
                    Console.WriteLine(key.Key);
                    Console.WriteLine("You need to enter Y");
                }
                else
                {
                    break;
                }
            }
        }
    }
}