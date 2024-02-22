using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class SwapList<T>: List<T>
    {
        public void Swap(int index1, int index2)
        {
            T temp = this[index1];
            this[index1] = this[index2];
            this[index2] = temp;
        }
    }
}
