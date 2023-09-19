using AccessSpecifierDemo2;

namespace AccessSpecifierDemo1
{
    public class AccessSpecifierClass3
    {
            public void Demo()
            {
                AccessSpecifierClass2 c = new AccessSpecifierClass2();
                // cannot access private variable
                //c.PrivateID = 123;
                c.PublicID = 20; // public can be accessed
                //c.ProtectedID = 20;// COMPILATION ERROR Protected cannnot be accessed by non derived classes
                //c.InternalID = 30;// Internal cannot be accessed class in different library
                //c.PrivateProtectedID = 200; // COMPILATION ERROR Provate Protected cannnot be accessed by non derived classes
                                          // in outside packages too
                //c.ProtectedInternalID = 300; // Since it does not meet protected and internal rules
                                 // it cannot be accessed in different library

            }
        }

        public class AccessSpecifierClass232 : AccessSpecifierClass2
        {
            public void Demo()
            {
            Console.WriteLine("Hello");
                AccessSpecifierClass2 c = new AccessSpecifierClass2();
                // cannot access private variable
                //c.PrivateID = 123;
                c.PublicID = 20; // public can be accessed
                ProtectedID = 20;// Protected can be accessed from different name space and different library
                //InternalID = 30;// Internal id cannot be accessed from different library
                //PrivateProtectedID = 200;// private overrides protected can be accessed by derived class
                                 // in different  library
                ProtectedInternalID = 300; // Can be accessed if in a different library
                                           // but it is a derived class
                                           // protected overrides

            }

            public void internalClassAccess()
            {
                // internal class in other library cannot be accessed from a class
                // in another library
                //InternalClass c = new InternalClass();
            }
    }
}