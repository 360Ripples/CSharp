namespace ExceptionModule
{
    public class CustomApplicationException : Exception
    {
        // Custom exception overriding the methods from Exception class
        public CustomApplicationException() { }
        public CustomApplicationException(String msg) : base(msg) { }
        public CustomApplicationException(String msg, Exception e) : base(msg, e) { }

    }
}
