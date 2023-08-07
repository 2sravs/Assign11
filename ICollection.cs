using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeDataCollectionAssign11
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> dataCollection;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            dataCollection = new List<object>(initialData);
        }

        public void AddElement(object element)
        {
            dataCollection.Add(element);
        }

        public void RemoveElement(object element)
        {
            dataCollection.Remove(element);
        }

        public object GetElement(int index)
        {
            if (index >= 0 && index < dataCollection.Count)
                return dataCollection[index];
            else
                throw new IndexOutOfRangeException("Index is out of range.");
        }   
        public void Dispose()
        {

            dataCollection = null;
            GC.SuppressFinalize(this);
            Console.ReadKey();
        }
        
    }
}
   
    