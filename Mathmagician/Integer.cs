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

        protected int Step { get; set; }

        public Integer()
        {
            Max = 50;
            Step = 1;
        }
        public virtual int GetFirst()
        {
            return 0;
        }
        
        public virtual int GetNext(int current)
        {
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            int[] sequence_array = new int[10];
            int counter = 0;
            sequence_array[counter] = GetFirst();
            while (counter < how_many - 1)
            {
                counter++;
                sequence_array[counter] = GetNext(sequence_array[counter - 1]);
            }
            return sequence_array;
        }
    }
}
