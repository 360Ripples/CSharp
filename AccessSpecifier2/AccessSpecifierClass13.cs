using AccessSpecifierDemo2;

namespace AccessSpecifierDemo3
{
    public class AccessSpecifierClass31
    {
        public void Demo()
        {
            AccessSpecifierClass2 c = new AccessSpecifierClass2();
            // cannot access private variable
            //c.PrivateID = 123;
            c.PublicID = 20; // public can be accessed
            //c.ProtectedID = 20;// COMPILATION ERROR Protected cannnot be accessed by non derived classes
            c.InternalID = 30;// Internal be accessed by non derived classes but in same library
                              // even if it is in a different name space
            //c.PrivateProtectedID = 200; // COMPILATION ERROR Provate Protected cannnot be accessed by non derived classes
                              // in outside packages too
            c.ProtectedInternalID = 300; // Can be accessed protected is overriden
                                         // since internal is specified it cab be accessed in the
                                         // same library
        }
    }

    public class AccessSpecifierClass232 : AccessSpecifierClass2
    {
        public void Demo()
        {
            AccessSpecifierClass2 c = new AccessSpecifierClass2();
            // cannot access private variable
            //c.PrivateID = 123;
            c.PublicID = 20; // public can be accessed
            ProtectedID = 20;// Protected can be accessed from different name space and different library
            InternalID = 30;// Internal id can be accessed from the same library and different namespace
            PrivateProtectedID = 200;// private protected can be accessed by derived class
                                     // in different pagage and library
            ProtectedInternalID = 300; // Can be accessed as it inside the same library
                                       // and protected is there

        }

    }
}
