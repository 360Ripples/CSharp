namespace OOPSDemo
{
    // Extension methods: 
    // These are methods which are added to a already developed class
    // Assume you need to develop a api called email validator in the string class
    // which will validate for valid email which ends with .com then we need to 
    // add this method in the string class, since it is part of CLR library we cannot
    // add it . For this purpose the extension methods was introduced. Below is the demo
    // 1. Extension class and methods should be static
    // 2. We can pass any number of parameters to the extension methods
    public static class StringExtensionDemo
    {
        // This extension methods will accept a email as the first paramter
        // and it will accept the string pattern to be mathced in the email string
        public static bool CheckEmail(this BaseClass ob, string s, string s1)
        {
            bool flag = s.EndsWith(s1);
            return flag;
        }
        //this BaseClass ob,string s, string s1
    }
}
