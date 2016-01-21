using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternLab
{
   public  interface IIterator
    {
       object First();
       object Next();
       bool IsDone();
       int CurrentItem();
    }
}
