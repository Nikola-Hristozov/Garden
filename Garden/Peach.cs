using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Peach : FruitTree
    {
        public Peach():base(5,5)
        {
        }

        public Peach(double energy, double waterRequiered) : base(energy, waterRequiered)
        {
        }
    }
}
