using AdvCSharp;
using CollectionsDemo;
using CSharpProjectDemo;
using ExceptionModule;
using OOPSDemo;
using System.Collections;
using System.Collections.Generic;

namespace MyFirstProject
{
    internal class MainClass
    {

         static void Main(string[] args)
         {

            // ConsoleDemo cd = new ConsoleDemo();
            //cd.consoleDemo();
            //Hello hello = new Hello();
            //hello.sayHello("Shanmu");

            //DataTypeDemo dataType = new DataTypeDemo();

            //dataType.dataTypeDemo();
            //DataCasting dataCasting = new DataCasting();
            //dataCasting.castingData();
            // Decision statement Demo
            //DecisionStatements dec = new DecisionStatements();
            //dec.ifElseDemo();
            //dec.ifElseIFDemo();
            //dec.ifElseNestedDemo();
            //dec.SwitchDemo();


            // Looping statement Demo
            //LoopDemo ld = new LoopDemo();
            //ld.DoWhileLoopDemo();
            //ld.WhileLoopDemo();
            //ld.ForLoopDemo();


            //StringDemo dem = new StringDemo();
            //dem.stringDemo();



            //StaticVariableDemo st = new StaticVariableDemo(888);
            //st.staticDemo();
            //StaticVariableDemo st1 = new StaticVariableDemo(8888);
            //StaticVariableDemo.x = 999;
            //st1.y = 300;
            //// the below object instances print the same value for x which is 999
            //// since x is static. But for y the values 300 and 200 is printed since
            //// it is not static.
            //Console.WriteLine("st1 Static Demo ");
            //st1.staticDemo();
            //Console.WriteLine("st Static Demo ");
            //st.staticDemo();
            ////The following code demonstrates the static method is invoked without a
            //// object instances
            //StaticVariableDemo.DisplayMessage();

            //// The following code demonstrates the error when a read only variable
            //// is changed in anyplace outside the constructor after initialization
            //st.constantDemo();
            //st1.constantDemo();



            //// Call by value Demo
            //Console.WriteLine("Call By Value");
            //Console.WriteLine("==============");
            //CallByValueReferenceDemo cv = new CallByValueReferenceDemo();
            //int x = 10, y = 20, z = 0;
            //cv.callByValue(x, y, z);
            //Console.WriteLine("{0} is the Value of Z", z);

            //String s = "John";
            //cv.callByReferenceAsValue(s);
            //Console.WriteLine($"Name is {s}");

            //Console.WriteLine("Call By Refernce");
            //Console.WriteLine("==============");
            //String s1 = "Harry";
            //cv.callByReferenceAsReference(ref s1);
            //Console.WriteLine($"Inside main after function invoked {s1}");

            //Console.WriteLine("Call By out");
            //Console.WriteLine("==============");
            //int t;
            //cv.callByOut(out t);
            //Console.WriteLine("inside main after function invoked" + t);

            //Console.WriteLine("Call By Params");
            //Console.WriteLine("==============");

            //cv.callByParams(1, 2, 3);
            //cv.callByParams(9, 12);

            // Constructor Demo

            //ConstructorDemo cdemo1 = new ConstructorDemo();
            //ConstructorDemo cdemo2 = new ConstructorDemo(1);
            // ConstructorDemo cdemo3 = new ConstructorDemo("Jack");
            // ConstructorDemo cdemo4 = new ConstructorDemo(1, "John");

            //// Copy constructor Demo
            //  ConstructorDemo cdemo5 = new ConstructorDemo(cdemo4);
            // Console.WriteLine("CDemo4=" + cdemo4);
            // Console.WriteLine("CDemo5=" + cdemo5);
            // //The above two objects may have the values copied but
            // //their references will be different 
            // Console.WriteLine("Equality Check=" + Object.ReferenceEquals(cdemo4, cdemo5));

            // D demo = new D();
            // demo.InheritanceConstructorDemo();

            //arrEg arrObj = new arrEg();
            //arrObj.arrayDemo();

            //// Value Object Demo
            //EmployeeVOProperties vo = new EmployeeVOProperties();
            //vo.Email = "abc.com";// read write property
            //                     // vo.Age = 30; // cannot set in age as it is a read only property
            //vo.MobileNumber = 9887764535; //Auo implemented property           
            //vo.EmpName = "Jill";// Write only property
            //                    // Console.WriteLine("name=" + vo.EmpName);      // throws error in RT

            //vo.SetEmployeeId("200");
            //Console.WriteLine("Employee VO== {0}", vo);

            ////Demo on equals method of objects

            //EmployeeVOProperties vo1 = new EmployeeVOProperties();
            //vo1.Email = "qwabc.com";// read write property
            ////vo.Age = 30; // cannot set in age as it is a read only property
            //vo1.MobileNumber = 8487764535; //Auo implemented property           
            //vo1.EmpName = "Jill";// Write only property
            //vo1.SetEmployeeId("300");
            //Console.WriteLine("Employee VO and VO1 equal=" + (vo == vo1)); //address
            //Console.WriteLine("Employee VO and VO1 equal=" + (vo.Equals(vo1)));

            // CheckedUncheckedDemo chkDemo = new CheckedUncheckedDemo();
            // when the below two numbers is added it returns -2147483648
            // which is unexpected as cause of data over flow in signed int it 
            // prints this negative value
            // chkDemo.add(-2147483648, 1);


            //Calc cal = new ScientificCalc();
            //cal.Add();
            //cal.Subt();

            //ScientificCalc ob = new ScientificCalc();
            //ob.Add();
            //ob.Subt();
            //ob.Sqroot();
            //ob.Sin();

            //OverloadingDemo overld = new OverloadingDemo();
            //overld.Print(2, 3);
            //overld.Print(4, 5, 6);

            //StringDemo sdemo = new StringDemo();
            //sdemo.stringDemo();

            //StaticClassDemo.hello();
            //StaticClassDemo.s = "Jack";
            // StaticClassDemo obj = new StaticClassDemo(); //error

            //InterfaceDemo id = new InterfaceDemoImpl();
            //id.Add();

            //loose coupling


            //   The following declaration can invoke all methods in 
            //the base interfaces too
            //InterfaceDemo2 id1 = new InterfaceDemoImpl1();
            //    id1.Multiply();


            //BaseClass cl = new ChildClass();
            //cl.Add(10, 20); // This will invoke the child class method
            // though the object is declared as parent object.
            //cl.Subtract(20, 30); // Scenario 1: Virtual/oveeride keyword NOT used in subtract method
            // This will trigger the base class subtract
            // method if the subtract in child class is
            // not a overriden method 
            // Scenario 2: Virtual/oveeride keyword  used in subtract method
            // This will trigger the child class subtract
            // method if the subtract in child class is
            //  a overriden method 


            //ChildClass cl1 = new ChildClass();
            //cl1.Subtract(20, 30); // Since it is declared as child variable
            // irrespective of whether the method is overriden
            // or not the child class will be executed

            // Demo on hiding methods

            //cl.Multiply(10, 20); // Scenario 1: If new keyword is used in the child  
            // class method , the base  class method will be trigerred
            // since the declaration is done as parent class. This is 
            // similar to no override or virtual keyword in the child class
            // If we dont specify the override or virtual keyword it is
            // same as new keyword in child class method, the only difference
            // is that you get a warning that the child class hides the
            // parent class method and you can remove the warning by informig
            // the compiler by adding the new keyword. So we are saying
            // that the method hiding is a intentiaonal behaviour


            // OverloadingClass oc = new OverloadingClass();
            //oc.Subtract(10, 20, 30);


            //Operator overloading demo
            //OperatorOverloadingDemo od = new OperatorOverloadingDemo(3, 1);
            //OperatorOverloadingDemo od1 = new OperatorOverloadingDemo(2, 3);
            //int result = od1 + od;
            //Console.WriteLine("Operator overloaing Addition Result= " + result);

            //bool flag = od1 == od;
            //Console.WriteLine("Operator overloading equal to Result= " + flag);



            //// EXTENSION API demo           
            //string s = "jack@gmail.com";
            //bool flag = s.CheckEmail(".com");
            //Console.WriteLine("String Extension response= {0}", flag);

            //string s = "jack@gmail.co";
            //BaseClass b = new BaseClass();
            //bool flag = b.CheckEmail(s, ".com");
            //Console.WriteLine("String Extension response= {0}", flag);

            //ChildClass b = new ChildClass();
            //b.Multiply(1,2);
            //NonGenericArrayList gen = new NonGenericArrayList();
            //gen.Demo1();

            //NonGenericHashTable hash = new NonGenericHashTable();
            //hash.DemoTableString();
            //hash.StoreEmployeeDetails();
            ////hash.StoreEmployeeRoleDetails();
            //NonGenericSortedList table = new NonGenericSortedList();
            //table.DemoTableString();
            //table.StoreEmployeeDetails();
            //table.StoreEmployeeRoleDetails();

            //NonGenericSortedList sortedTable = new NonGenericSortedList();
            //sortedTable.DemoTableString();



            //GenericCollectionList list = new GenericCollectionList();
            //list.StoreList();
            //list.StoreHashSet();
            //list.StoreSortedSet();
            //list.StoreCountryNameSortedSet();
            //list.StoreEmployeeSortedSet();

            //GenericDictionary dict = new GenericDictionary();
            //dict.StoreStringData();
            //dict.StoreEmployeeDetails();
            //dict.StoreEmployeeRoleDetails();

            //ExceptionDemo e = new ExceptionDemo();
            //Console.WriteLine("Enter Number 1");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number 2");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //e.ThrowCustomException(n1, n2);
            //e.TryCatchFinallyDemo(n1, n2);
            //e.MultipleCatchFinallyDemo(n1, n2);
            //e.NestedCatchFinallyDemo(n1, n2);

            //CustomExceptionDemo ce = new CustomExceptionDemo();
            //try
            //{
            //    ce.ThrowCustomException(n1, n2);
            //}
            //catch (CustomApplicationException ex) // Thrown error is caught here
            //{
            //    Console.WriteLine("Exception in Main class " + ex.Message);
            //}

            //NamedAndOptionalParamters ob = new NamedAndOptionalParamters();
            //ob.display(10, 20);
            //ob.display(b: 2, a: 4);
            //// ob.display(b:12, 34); //error
            //ob.display2(1, 2);
            //ob.display2(40);

            //PartialClassDemo o = new PartialClassDemo();

            //AutoMapperDemo autoDemo = new AutoMapperDemo();
            //autoDemo.TraditionalMapper();
            //autoDemo.AutoDemo();

            //LambdaDemo lam = new LambdaDemo();
            //lam.DemoLambda();

            LinqDemo linObj=new LinqDemo();
            //Console.WriteLine("Query Syntax ");
            //linObj.WhereClauseQueryDemo();
            //Console.WriteLine("Method Syntax ");
            //linObj.WhereClauseMethodDemo();
            //Console.WriteLine("Mixed Syntax");
            //linObj.WhereClauseMixedDemo();
            //linObj.OrderByDemo();
            // linObj.GroupByDemo();
            //linObj.ThenClauseDemo();
            //linObj.FirstDemo();

            //linObj.TakeDemo();
            //linObj.SkipDemo();
            //linObj.AggregateDemo();
            //linObj.DistintDemo();
            //linObj.takeWhileDemo();
            // linObj.ExceptDemo();
            //linObj.UnionDemo();
            // linObj.IntersectDemo();
            //linObj.ContainsDemo();
            //linObj.AllDemo();
            // linObj.AnyDemo();

            //linObj.selectMAnyDemo();
            //linObj.FirstOrDefaultDemo();
            SortedList<string,string> table=new SortedList<string, string>();
            table.Add("India", "New Delhi");
            table.Add("China", "Beijing");
            table.Add("Russia", "Moscow");
            table.Add("USA", "Washington");
            table.Add("Russiaa", "Moscow");
            table.Add("Russiad", null);
            //table.Add(null, "Moscow");
            foreach (var a in table)
                 Console.WriteLine(a);
        }

    }
}