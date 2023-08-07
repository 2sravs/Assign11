using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeDataCollectionAssign11
{
    
    public class Program
    {
        public static void Main()
        {
            var initialData = new List<object> { 1, 2, 3, "hello", "world","sravani" };
            using (var dataCollection = new LargeDataCollection(initialData))
            {
                dataCollection.AddElement(4);
                dataCollection.AddElement("sravani");


                Console.WriteLine("Accessing element at index 2: " + dataCollection.GetElement(3));


                dataCollection.RemoveElement(2);

                Console.WriteLine("Accessing element at index 2 after removal: " + dataCollection.GetElement(2));
            }
            Console.ReadKey();

        }
    }
}
