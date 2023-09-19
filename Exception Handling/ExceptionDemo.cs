namespace ExceptionModule
{
    public class ExceptionDemo
    {
        // Try cannot be alone and it has to either have catch or finally

        // This catches a general catch clause 
        public void TryCatchDemo(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch  //Alternate is catch(Exception e)
            {
                Console.WriteLine("Divide by Zero Exception caught");
            }
        }

        // Try Catch finally
        public void TryCatchFinallyDemo(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("divide by zero exception caught");
                Console.WriteLine(e);
            }
            finally { Console.WriteLine("Finally trigerred"); }
        }

        // Multiple Catch example
        public void MultipleCatchFinallyDemo(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
                Console.WriteLine("Ener a number");
                int j = Convert.ToInt32(Console.ReadLine()); // Enter a sting in user input
                                                             // to simulate the error

                FileStream fileStream = new FileStream("d:/abc.xt", FileMode.Append);
                //Simulating the file not found exception
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception caught");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exception caught");
            }
            catch (Exception e) // Any exception apart from format
                                // or divide by zero will be handled by this catch block
            {
                Console.WriteLine(e.StackTrace); // Not a good practise for demo we have put stack trace
                Console.WriteLine("Generic exception caught");
            }
            finally { Console.WriteLine("Finally trigerred"); }
        }

        // Demo for nested exceptions
        public void NestedCatchFinallyDemo(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
                try
                {
                    Console.WriteLine("Ener a number");
                    int j = Convert.ToInt32(Console.ReadLine()); // Enter a sting in user input
                    //int i=4 / j;                                         // to simulate the error
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Format exception caught");
                }
                FileStream fileStream = new FileStream("d:/abc.xt", FileMode.Append);
                //Simulating the file not found exception
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception caught");
            }
            catch (Exception e) // This will also be executed if the nested exception occurs
                                // in our case if a format exception occurs this catch block
                                // will also be trigerred
            {
                Console.WriteLine(e.StackTrace); // Not a good practise for demo we have put stack trace
                Console.WriteLine("Generic exception caught");
            }
            finally { Console.WriteLine("Finally trigerred"); }
        }
    }
}