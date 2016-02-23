using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer
    {
        public Even()
        {
            Step = 2;
        }
        public override int GetFirst()
        {
            return 2;
        }
    }
}
