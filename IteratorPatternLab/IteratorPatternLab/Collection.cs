using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternLab
{
   public class Collection:ICollection
    {
       private ArrayList items = new ArrayList();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
        public int this[int index]
        {
            get { return (int)items[index]; }
            set { items.Add(value); }
        }
    }
}
