namespace ExceptionModule
{
    public class CustomExceptionDemo
    {

        // This throws custom Exception InvalidNumber Exception
        public void ThrowCustomException(int a, int b)
        {
            try
            {
                if (a <= 0 || b <= 0)
                {
                    throw new InvalidNumberException("Numbers cannot be zero or negative value");
                }

                Console.WriteLine(a / b);
            }
            catch (Exception e) // Thrown invalidNumber Exception is caught here
            // wrapped as a custom application exception and thrown back.
            {
                Console.WriteLine("Exception: " + e.Message);
               
                throw new CustomApplicationException("Exception when dividing numbers", e);

            }
        }
    }
}
