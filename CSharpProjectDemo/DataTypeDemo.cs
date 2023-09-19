namespace CSharpProjectDemo
{
    internal class DataTypeDemo
    {
        public void dataTypeDemo()
        {
            // stores value from 0 to 255
            byte b = 255;
            sbyte sb = -128;
            Console.WriteLine("Byte value= " + b);
            Console.WriteLine("Signed Byte value= " + sb);

            //Charachter data type
            char c = 'B';
            Console.WriteLine("Charachter" + c);
            Console.WriteLine("ASCII" + (byte)c);

            

            // Numeric Data Type signed
            //int stores from -2147483648 to 2147483647
            //long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Int16 i = 10;
            Int32 j = 23456;
            Int64 k = 45678999;

            // Alternative for 16,32,64 as below signed
            short i1 = -10;
            int j1 = 23456;
            long k1 = 45678999;

            //unisgned int data types
            ushort i2 = 10;
            uint j2 = 23456;
            ulong k2 = 45678999;


            //Decimal Values
            //float stores 6 to 7 decimal digits
            //double 15 decimal digits
            //end with d and f
            float f = 234.54f;
            double d = 3456.78;

            //Alternative for float
            Single f1 = 234.56f;

            //Alternative for double
            Double d1 = 234.56;



            Console.WriteLine(i1);

            DateTime dat = new DateTime(2023,12,13,10,20,30);
            DateOnly donly = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine(donly.ToString());

            //String or string you can use both for defining string data type. It is a reference data type
            String s = "String Demo";

            String s1 = new string("String Demo");
            bool isEquals = s.Equals(s1);
            //returns true
            Console.WriteLine("Value of Equals method " + isEquals);
            if (s == s1)
            {
                Console.WriteLine("Equal" + isEquals); // Unlike Java it always checks the value of string and not reference
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            string names = "Deepika\nPriya\nRamya";
            Console.WriteLine("NAMES ARE: " + names);
            string msg = "Welcome to \"c++\" World";
            Console.WriteLine(msg);
           
            //STRING INTERPOLATION
            Console.WriteLine($"String= {s}");
            Console.WriteLine($"Value is {2 + 4}");

            //VERBATIM
            string path = @"C:Users\Documents\csharp\";
            string strmsg = @"hello
                          World";
            Console.WriteLine(strmsg);
            Console.WriteLine(path);

            //VERBATIM STRING INTERPOLATION
            Console.WriteLine($@"hello {s}
                         WORLD");

            //COMPOSITE FORMATTING
            string str = "Deepika";
            string newMsg = "have a nice day";
            Console.WriteLine("Welcome {0}, Good Morning {1}. ", str, newMsg);
          
        }
    }
}
