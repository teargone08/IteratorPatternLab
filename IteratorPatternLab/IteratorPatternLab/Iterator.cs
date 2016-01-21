using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternLab
{
   public  class Iterator:IIterator
    {
       private Collection collection;
       private int current;
       public Iterator(Collection newCollection)
       {
           this.collection = newCollection;
           current = 0;
       }
        public object First()
        {
            return collection[0];
        }

        public object Next()
        {
           
            if (!IsDone())
            {
                object obj = collection[current];
                current++;
                return obj;
            }
            return null;
            
        }

        public bool IsDone()
        {
            return current >= collection.Count;
        }

        public int CurrentItem()
        {
            return collection[current];
        }
    }
}
