using System.Collections;
using System.Collections.ObjectModel;

namespace CollectionsDemo
{
    public class NonGenericArrayList
    {
        //Adding few string elements in the List
        // Iterating the elements and printing it
        // Accessing elements using the index
        // Adding multiple data type in the nongeneric array list
        // Inserting a element in the approritae index
        // inserting another list in the existing list after a index
        public void Demo1()
        {
            ArrayList list = new ArrayList();
            list.Add("India");
            list.Add("USA");
            list.Add("China");
            list.Add("Russia");
            list.Add(null);
            list.Add(null);
            
            int count = list.Count;
            Console.WriteLine("List Count {0}", count);
            int counter = 1;
            foreach (string item in list)
            {
                if (counter < count)
                    Console.Write(item + "-");
                else
                    Console.Write(item);
                counter++;
            }

            Console.Write("\n");
            Console.WriteLine("List 4th element is {0}", list[3]);
            list.Add(123);
            Console.WriteLine("List 5th element is {0}", list[4]);

            
            list.Add(123);// adding duplciate elements in the list
            Console.WriteLine("*******List after adding duplicates******");

            foreach (var item in list)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();
            // removing an element from a list
            list.RemoveAt(4);
            // this removes a specific value present in the list but first occurence only
            list.Remove(123);
            // Now in the list China Russia will be moved to the next index
            list.Insert(2, "Cambodia");
            // 3rd element was russia now it will be china
            Console.WriteLine("List 3rd element is {0}", list[3]);


           
            // Adding a list o another list
            ArrayList childList = new ArrayList();
            childList.Add("Apple");
            childList.Add("Grapes");
            childList.Add("Orange");
            list.InsertRange(4, childList); // new list added after the last element
            count = list.Count;
            counter = 1;
            Console.WriteLine("List Count {0}", count);
            foreach (var item in list)
            {
                if (counter < count)
                    Console.Write(item + "-");
                else
                    Console.WriteLine(item);
                counter++;
            }

            //list.Sort();
            Console.WriteLine("Element Exists {0}", list.Contains("USA"));

            // Cloning array list
            ArrayList duplicateList = (ArrayList)list.Clone();
            //Checking if the duplicate list is in a different memory
            Console.WriteLine("Are both references same {0} ", ArrayList.ReferenceEquals(list, duplicateList));

            duplicateList.Add("Jack");

            // Though a element was added to the duplicate list when iterated the 
            // original list it does not have that element . This shows that
            // the new list is a new reference and it has its own copy of elements
            foreach (var item in list)
            {
                Console.Write(item + "--");

            }
            Console.WriteLine("\n");
            Console.WriteLine("Duplicate list elements");
            foreach (var item in duplicateList)
            {
                Console.Write(item + "--");

            }

        }
    }
}
