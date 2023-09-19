using System.Collections;

namespace CollectionsDemo
{
    public class NonGenericSortedList
    {
        // SortedList stores value in key value pair
        // String/ String
        public void DemoTableString()
        {
            // Adding Elements, It will be automatically added in sorted order of key.
            SortedList table = new SortedList();
            table.Add("India", "New Delhi");
            table.Add("China", "Beijing");
            table.Add("Russia", "Moscow");
            table.Add("USA", "Washington");
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }
            // ALL THE METHODS ARE SAME AS HASTABLE.
            // Fetching elements based on Key
            Console.WriteLine("Capital of USA is {0}", table["USA"]);

            //Checks if the key is present in the given HashTable
            Console.WriteLine("Is India present in the table data {0}", table.ContainsKey("India"));

            //Checks if the value is present in the given HashTable
            Console.WriteLine("Is Moscow present in the table data {0}", table.ContainsValue("Moscow"));

            // Removing a row
            table.Add("Cambodia", "Phnom Penh");
            table.Remove("China");
            Console.WriteLine("Removed China from table -->{0}", table.ContainsKey("China"));

            // Printing values in the table as rows and columns
            Console.WriteLine("===================");
            Console.WriteLine("Country     Capital");
            Console.WriteLine("===================");
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0}  {1}", entry.Key, entry.Value);
                Console.WriteLine("-------------------");
            }


        }

    }
}
