using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int Max { get; private set; }

        public Integer()
        {
            Max = 50;
        }

        public int GetFirst()
        {
            return 0;
        }
        
        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            int[] sequence_array = new int[10];
            for (int i = 0; i < how_many; i++)
            {
                sequence_array[i] = i;
            }
            return sequence_array;
        }
    }
}
