namespace ExceptionModule
{
    public class InvalidNumberException : Exception
    {
        // Custom exception overriding the methods from Exception class
        public InvalidNumberException() { }
        public InvalidNumberException(String msg) : base(msg) { }
        public InvalidNumberException(String msg, Exception e) : base(msg, e) { }

    }
}
