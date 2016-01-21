using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternLab
{
   public interface ICollection
    {
       Iterator CreateIterator();
    }
}
