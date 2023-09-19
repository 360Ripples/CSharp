namespace AccessSpecifierDemo2
{
    public class AccessSpecifierClass2
    {
        // cannot be accessed from any class
        private int PrivateID = 10;
        public int PublicID = 11;
        protected int ProtectedID = 12;
        internal int InternalID = 12;
        private protected int PrivateProtectedID = 10;
        internal protected int ProtectedInternalID = 10;
    }


    // Same library DLL but not derived class
    public class AccessSpecifierClass21
    {
        public void Demo()
        {
            AccessSpecifierClass2 c = new AccessSpecifierClass2();
            // cannot access private variable
            //c.PrivateID = 123;
            c.PublicID = 20; // public can be accessed
            //c.ProtectedID = 20;// COMPILATION ERROR Protected cannnot be accessed by non derived classes
            c.InternalID = 30;// Internal be accessed by non derived classes but in same library
            //c.PrivateProtectedID = 200;// COMPILATION ERROR Provate Protected cannnot be accessed by non derived classes
            c.ProtectedInternalID = 300;// protected Internal be accessed by non derived classes but in same library and package

        }

    }
    // Same library DLL but  derived class
    public class AccessSpecifierClass22 : AccessSpecifierClass2
    {
        public void Demo()
        {
            AccessSpecifierClass2 c = new AccessSpecifierClass2();
            // cannot access private variable
            //c.PrivateID = 123;
            c.PublicID = 20; // public can be accessed
            ProtectedID = 20;// Protected can be accessed
            c.InternalID = 30;// Internal id can be accessed from the same library and sam namespace
            PrivateProtectedID = 200;// private protected can be accessed by derived class
                                     // in same pagage and library
            ProtectedInternalID = 300; // Deived class can access protected internal id
                                       // but in same package and library
        }

    }


    // A internal class demp to check if it can be accessed
    // from other class in other DLL
    internal class InternalClass
    {
        public void Demo()
        {

        }

    }


}