namespace CSharpProjectDemo
{
    internal class DataCasting
    {
        public void castingData()
        {
            // Implicit casting  small dt to large dt
            int i = 100;
            double d = i;
            Type type = d.GetType();
            Console.WriteLine(d.GetType());

            //Explicit casting  large to small
            float f = 100.45f;
            int j = (int)f;
            Console.WriteLine($"Casted int {j}");

            // Converting using Helper methods

            int k = Convert.ToInt32(f);
 
            string s = "123";
            int k1 = Convert.ToInt32(s);
            Console.WriteLine($"Casted string {k1}");

            //The below code will throw and error.
            string s1 = "Hello";
            //int k2 = Convert.ToInt32(s1);

            //Similarly we have methods to convert to booelan double string byte etc.


            //Parse method of the respective data types to convert data
            string s2 = "100";
            int l = int.Parse(s2);
            String s3 = "true";
            bool b = bool.Parse(s3);
            Console.WriteLine($"String casted as Boolean  {b}");

            //Type casting to prevent errors using TryParse
            string s4 = "987";
            bool b1 = int.TryParse(s4, out int l2);
            Console.WriteLine($"Boolean casted Status {b1}"); // return false in case of errors
            Console.WriteLine($"Integer casted from string {l2}"); // returns if the cast is without errors





        }
    }
}
