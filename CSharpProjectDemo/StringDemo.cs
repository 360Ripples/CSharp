using System.Text;

namespace CSharpProjectDemo
{
    class StringDemo
    {
        public void stringDemo()
        {   //immutable
            // String is a reference object in c#
            // string and String are the same 
            // string is a alias of String
            // the following are called string "interns" and does not create a new 
            // memory location in the memory rather points to the same memory
            // location , liek java literals
            string s = "abc";
            String s1 = "abc";

            // String interns  is compared so it will be true
            Console.WriteLine("s and s1 equal= {0}", s == s1);

            String s2 = new String("abc");

            // String interns  is compared with string object unlike java
            // it compares the values so returns true
            Console.WriteLine("s1 and s2 equal= {0}", s2 == s1);

            //Sring equals using equals- true
            Console.WriteLine("s1 and s2 using equals = {0}", s2.Equals(s1));

            //Sring equals using equals references method
            // This compares the address thus returns false
            Console.WriteLine("s1 and s2 using reference equals = {0}", String.ReferenceEquals(s1, s2));


            // String is immutable
            // returns true as the string interns point same address
            Console.WriteLine("s and s1 interns using reference equals = {0}", String.ReferenceEquals(s1, s));
            s1 = "xyz";
            // returns false as the string interns point to different address
            // as interns have different values
            // This proves string is immutable and every time we change the string value a
            // new address is created and a value is created
            Console.WriteLine("s and s1 interns using reference equals after changing value= {0}", String.ReferenceEquals(s1, s));

            char[] letters = { 'H', 'A', 'I' };
            string str2 = new string(letters);
            string ss1 = "abcd";
            string ss2=string.Intern(ss1);
            Console.WriteLine("Intern ="+string.ReferenceEquals(ss1, ss2));
           
            String name = "Deepika";
            string course = "MCA";
            string details = string.Format("Name:{0},Course:{1}", name, course);
            //Name:Deepika,Course:MCA
            string sentence = "Hello Guys! Welcome to CSharp Training";
            string message = (string)sentence.Clone();
            Console.WriteLine("IndexOf o = " + sentence.IndexOf('o'));  //starts from 0
            Console.WriteLine("length=" + sentence.Length);
            Console.WriteLine("Comparing strings =" + string.Compare(sentence, message));
            
            Console.WriteLine(String.ReferenceEquals(sentence, message)); //true becoz interns
            
            message = "Hello";
            Console.WriteLine("Refernce equals after changing value=" + String.ReferenceEquals(sentence, message));
            Console.WriteLine("Compare after change=" + string.Compare(sentence, message));
            Console.WriteLine("Concat=" + string.Concat(sentence, message));   //only display
            Console.WriteLine("Contains=" + sentence.Contains(message));
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.Substring(3, 8));  // 8 is length
            Console.WriteLine(sentence.Insert(19, "All "));
            Console.WriteLine(sentence);

            
            // Example of a strng builder class which is mutable.
            StringBuilder sb = new StringBuilder("Harry");
            // This appends the new string to the same string in the same address
            
            sb.Append("Potter");
            Console.WriteLine("Appended String {0}", sb);
            sb.Remove(7, 3);    //includes 7,8,9
            Console.WriteLine("After removal " + sb);
           
        }
    }
}
